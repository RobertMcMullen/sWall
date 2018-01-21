using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Xml;
using System;
using UnityEngine.SceneManagement;




//Robert McMullen 100977031
//sWall Game/Activity

public class GamePlay : MonoBehaviour {

    //TODO Add touchScreen Vector movement  
    //TODO Add a teardown method 
    //Idea sounded good but most methods are helper/actionListeners so its not really possible

    //TODO Use PlayerPrefs
    


    /********************************************/
    /********  Public Variables  ****************/
    /********************************************/
    public Canvas background;//Parent class for the map
    public Camera cam;//main camera
    public RawImage map;//the map image
    public RawImage pin;//The location of the image to guess pre-determined by data    
    public Button conf;//Confirm button placed underneath the guess made by the player
    public Button nextRoundButton;//Button to be pressed when the player confirms and is ready to play the following round.
    public Button mainMenuButton;//Button for the endGame that allows the player to go to the main menu.
    public RawImage pinLocked;//Mirror of pin but with pink color
    public Image randomImageToGuess;//Contains a random image from a list that the user must guess its location    
    public List<Sprite> images;//List containing all the images that get displayed that the user must guess    
    public Text scoreText;//Contains the current score of the player, initialy starts at 00000
    public Text roundText;//Contains the current round of the player / the total round; ex 1/3 == round 1 of 3
    public Text gameOverText;//Contains the words Game Over and is to be played at the end of the game once all the rounds have been played out.
    public TextAsset locations;
    public static GamePlay instance;


    /********************************************/
    /***************   Flags  *******************/
    /********************************************/
    private bool pinCreate;//Flag for creating pin, true==pin on screen false==no pins.
    private bool locked;//If true the guess is locked in and no more guesses allowed.
    private bool clickable;//Set to false while a picture is shown on screen then true once you can click
    private bool testing = false;//If true then the pictures aren't random 
    private bool verbose = true;//If set to false then all logs disabled. If true logs will display to console
    

    /********************************************/
    /************  Pins & Buttons  **************/
    /********************************************/
    private Button guessButton;//Confirm button for when making a guess
    private RawImage guessPin;//holds the pink texture of the pin
    private Image newGuessImage;//Contains the new created duplicate of the placeHolder image.

    /********************************************/
    /****************  Vecotors  ****************/
    /********************************************/
    private Vector3 pinVec; // Vector for the pin
    private Vector3 clickLocation;//Vector for holding the x,y,z location of the mouse click
       
    /********************************************/
    /****************  Constants  ***************/
    /********************************************/
    private int maxScore = 4000;//The perfect score achievable, for now it will subtract the distance from this number and that is your score.
    private int guessMinBuffer = 20;//If you guess within this number it will round to a perfect score
    private int guessMaxBuffer = 3800;//If you guess over this distance it will be a 0. (~3800 is corner to corner)
    private float zoomValue = 150f;// Value for how much the camera zooms in and out        
    private List<int> usedImageIndexes;//Holds the indexes for the called images

    /********************************************/
    /***********  Gameplay Related  *************/
    /********************************************/
    private float guessDistance;// Contains the distance of the users guess
    private float score; //Contains the current running score of the player
    private int currentRound;//Holds the current round of the game
    public static int maxRound = 3;//Contains the max rounds to be played for 1 match   
    public static float waitTime = 5.0f; // Float for how long the picture stays up on the screen(in seconds)



    void Start() {//sets flags      

        if (verbose)
        {
            Debug.Log("Waiting for " + waitTime + "s");
            Debug.Log("Playing " + maxRound + " Rounds");
        }
        setRound(1, maxRound);
        gameOverText.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);
        nextRoundButton.onClick.AddListener(nextRound);
        mainMenuButton.onClick.AddListener(delegate { goTo("MainMenu"); });

        usedImageIndexes = new List<int>();
        instance = this;
        pinVec.x = pin.transform.position.x;
        pinVec.y = pin.transform.position.y;
        pinVec.z = 0;
        pinCreate = false;
        locked = false;
        clickable = false;
        currentRound = 1;
        
        Debug.Log(Application.dataPath);
        playRound();


    }

    public void playRound()//Gets called to start the round
    {
        pin.enabled = false;
        showPicture();
        Invoke("removeOldImage", waitTime);//Invokes the method removeOldImage 'waitTime' from now
    }

    private void setXY(int index)//Get the xy coordinates from an XML doc for each picture 
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(Application.dataPath + "/Scripts/Locations.xml");//This may cause an error after building, not sure
        var baseNode = xmlDoc.DocumentElement;

        foreach (XmlNode node in baseNode.ChildNodes)//Parse the xmlDoc for the specific image.
        {
            /*
            if (verbose)
            {
                //Debug.Log("Index num = " + index);
                //Debug.Log("Node Name: " + node.Name);
                //Debug.Log("Node Inner Text: " + node.SelectSingleNode("num").InnerText);
                //Debug.Log("Node X: " + node.SelectSingleNode("x").InnerText);
            }
            */
            if (Int32.Parse(node.SelectSingleNode("num").InnerText).Equals(index))
            {
                float posX = float.Parse(node.SelectSingleNode("x").InnerText);
                float posY = float.Parse(node.SelectSingleNode("y").InnerText);
                if (verbose)
                {
                    Debug.Log("Real location X: " + posX);
                    Debug.Log("Real location Y: " + posY);
                }

                moveRealLocationPin(posX, posY);
            }

        }

    }

    public void confirmLocation()//action listenere class called when confirm button clicked
    {
        pin.enabled = true;
        nextRoundButton.gameObject.SetActive(true);
        locked = true;
        guessPin.texture = pinLocked.texture;
        Destroy(guessButton.gameObject);
        guessDistance = getDistance(pinVec, clickLocation);
        calculateScore();
        if (currentRound == maxRound)//Checks to see if the last round was just played
        {           
            endGame();
        }

    }

    void Update() //Check if click location is the same as the button location
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 shift = new Vector3(150, 0, 0);
            cam.transform.position -= shift;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 shift = new Vector3(150, 0, 0);
            cam.transform.position += shift;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 shift = new Vector3(0, 150, 0);
            cam.transform.position += shift;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 shift = new Vector3(0, 150, 0);
            cam.transform.position -= shift;
        }        

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)// Zoom with Scroll Wheel
        {
            if ((cam.orthographicSize - zoomValue > 0))//Need to make sure you can't zoom in past the image.
            {
                cam.orthographicSize -= zoomValue;
            }
        }
        // Scoll back
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            cam.orthographicSize += zoomValue;

        }
        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == null && locked == false && clickable == true)//== null means you clicked in the empty space and not the button
        {

            clickLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickLocation.z = 0;
            clickLocation.y += 45;//Need to offset since the point is at the bottom of the image. Shift up to move the center of the image to the bottom point.
            createNewPin(clickLocation);
        }

    }

    private void generateTestGuess()//Generates a new vector and pin at a random location after waiting 3 seconds using the WaitTime method
    {               
        int randomXValue = UnityEngine.Random.Range(-1070, 1070);//X Ranges from -1070 to +1070
        int randomYValue = UnityEngine.Random.Range(-1570, 1680);//Y Ranges from -1570 to 1680
        Vector3 randomTestGuessVect = new Vector3(randomXValue, randomYValue, 0);
        //createNewPin(randomTestGuessVect);            
        StartCoroutine(WaitTime(3,randomTestGuessVect));
    }
    IEnumerator WaitTime(float duration, Vector3 guessVect)//Waits duration that creates a new pin at the input vector.
    {
        
        print("Begin Wait" + Time.time);
        yield return new WaitForSeconds(duration);
        createNewPin(guessVect);
        print("Done waiting" + Time.time);
    }

    private void print(String s)//Helper method, easier to type print than Debug.log(...)
    {
        Debug.Log(s);
    }

    private bool checkVector(Vector3 inputVector)//Returns true if the pin should be created within the playing area and false if the click is on the headers.
    {
        if (verbose)
        {
            print("Checking Vector...");
        }
        if (inputVector.y < -1580)
        {
            //Too low           
            return false;
        }
        else if (inputVector.y > 1700)//If the location of the pin is covered by the header
        {
            
            //Too high
            return false;

        }
        else return true;
    }

    private void createNewPin(Vector3 inputVector)//Create a pin at the x,y,z location
    {
        if (verbose)
        {
            print("Creating new pin");
        }               
        if (checkVector(inputVector)) {
            if (pinCreate)//Remove the old button
            {
            removeOldComponents();//make sure there is only ever one pin on the screen at a time
            }
        pinCreate = true;//After the 1st iteration pinCreate will always be true
        guessButton = Instantiate(conf);
        guessPin = Instantiate(pin);
        guessPin.transform.SetParent(background.transform);
        guessPin.transform.position = inputVector;
        guessPin.enabled = true;
        Vector3 confirmVect = inputVector;
       

            if (inputVector.y < -1450)//If the location is too low we don't want to clip the confirm button.
        {
            confirmVect.y = inputVector.y + 150; //flip it so that the confirm button is on the top rather than below so it doesn't get clipped
        }        
        else//Offset pin so that it sits lower since the point of the pin is below its center and create it
        {
            confirmVect.y = inputVector.y - 150;
        }

        guessButton.transform.SetParent(background.transform);
        guessButton.transform.position = confirmVect;
        guessButton.onClick.AddListener(confirmLocation);

        }
       
    }

    private void moveRealLocationPin(float posX,float posY)//Updates the pin's position for scoring and physically moves it
    {
        Vector3 pinVector = new Vector3(posX, posY, 0);
        pinVec.x = posX;//Change the values for the scoring
        pinVec.y = posY;

        pin.transform.position = pinVector;//Physically move the pin on the screen
    }

    private void removeOldComponents()//cleanup the previous guesses.
    {
        if (verbose)
        {
            print("Removing Old Components");
        }
        Destroy(guessButton.gameObject);
        Destroy(guessPin.gameObject);

    }
    
    private float getDistance(Vector3 initial,Vector3 guess)//returns a float containing the distance between the guess and the real location
    {
        
        Debug.Log("GUESS:" +guess.x + "," + guess.y);       
        float distance = Vector3.Distance(initial, guess);
        return distance;
    }
    
    private void showPicture()//To make the picture dissapear move it behind the map, then to bring it back move it ahead.
    {
        nextRoundButton.gameObject.SetActive(false);//Disable the Next Round button while viewing a picture
        Sprite rand = getRandomImage();
        newGuessImage = randomImageToGuess;       
        newGuessImage = Instantiate(newGuessImage);
        newGuessImage.sprite = rand;//Sets the image to the random one from the array of images.        
        newGuessImage.transform.SetParent(background.transform);       
        
    }

    private void removeOldImage()//deletes the duplicate image keeping the orignial
    {           
        Destroy(newGuessImage.gameObject);
        clickable = true;

        /*
        if (testing)
        {//Generate 3 random tests
           for(int i = 0; i <= 3; i++)
            {
                generateTestGuess();
            }
        }
        */
    }

    private Sprite getRandomImage()//Gets a random image from a secondary array, then removes this image from that array so that you can't get the same image twice
    {
        if (testing)//If testing mode on, no random, cycle through images sequentially
        {
            int indexTest = 0;
            Sprite currentImageTesting = images[indexTest];
            images.RemoveAt(indexTest);//Remove the called image so that there is no repitition
            return currentImageTesting;

        }
        else//**Normal operation**
        {
            int count = images.Count;//Contains the max num of elements in the noDoubles array.
            int index = UnityEngine.Random.Range(0, count);//Generates a new random number            
            if (usedImageIndexes.Count == count)
            {
                endGame();
                return null;//Doesn't matter what you return, out of pictures anyway & endgame will take care of this
            }
            else//If there are still iamges left
            {
                while (usedImageIndexes.Contains(index))
                {
                    index = UnityEngine.Random.Range(0, count);
                   // Debug.Log("duplicate index: " + index);
                }
                usedImageIndexes.Add(index);                
                Sprite currentImage = images[index];
                setXY(index);
                return currentImage;
            }
        }
    }   
    
    private void calculateScore()
    {
        
        if (guessDistance < guessMinBuffer) //Small buffer to give a perfect score.
        {
            score += maxScore;
        }
        else if (guessDistance > guessMaxBuffer)//This can only happen if the the real vs. the guess is corner to corner ie: worst case;
        {                                       //This is considered a complete loss and should be a 0, doubt this will ever happen
            score = 0;
        }
        else //Base case for scoring is to subract distance from the max score.
        {
            score += maxScore - guessDistance;
        }


        int scoreInt = (int)score;//Casting to int removes all the digits after the decimal       
        setScore(scoreInt);
               

    }

    public void setRound(int roundNum,int totalRound)//Setter for the text box, roundNum is the current round and totalRound is the overal rounds
    {
        roundText.GetComponent<Text>().text = roundNum.ToString() + "/" + totalRound.ToString() ;
    }

    public void setScore(int newScore)//Changes how much score the player has
    {
        scoreText.GetComponent<Text>().text = newScore.ToString();
    }

    private void centerCamera()//At the end of the round this method gets called to reset the camera to its orignial position with no zoom and no transforms
    {
        Vector3 resetPosition = new Vector3(0, 0, -10);
        cam.transform.position = resetPosition;
        cam.orthographicSize = 1920;//TODO make this not a specific value for now it should be fine
        //This should be tested on the real monitors
        
    }

    public void nextRound()//Load up the next image and play another round incrementing the round and score.
    {
        clickable = false;        
        currentRound += 1;
        centerCamera();
        showPicture();
        pin.enabled = false;
        Invoke("removeOldImage", waitTime);//Invokes the method removeOldImage 'waitTime' from now
        Destroy(guessPin.gameObject);
        locked = false;//reset the clicking on the screen
        pinCreate = false;
        setRound(currentRound, maxRound);        
        
       
    }
    public void goTo(String scene)//Takes the player to the main menu
    {//Depending on the size of the game, this method could adapt to take a parameter of the location to go to rather than only the main menu.

        SceneManager.LoadScene(scene);
    }
    

    public void endGame()//Called once the max rounds have been played.
    {
        /*Once the game ends the following take effect:
         * 
         * 1. Game Over text is displayed onto thte screen
         * 2. The Next Round button can be re-used but with the words Play Again?
         * 2a.Another button should be added next to it saying main menu?
         * 3. The contents of the screen should be locked aside from those 2 buttons.
         * */
            
        print("The game is over");
        gameOverText.gameObject.SetActive(true);
        mainMenuButton.gameObject.SetActive(true);
        nextRoundButton.GetComponentInChildren<Text>().text = "Play Again?";
        nextRoundButton.onClick.AddListener(delegate { goTo("GamePlayRound"); });
        
        

    }

}
