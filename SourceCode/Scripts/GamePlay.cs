using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Robert McMullen 100977031
//sWall Game/Activity

public class GamePlay : MonoBehaviour  {
    //TODO Add panning/camera movement
    //TODO Add touchScreen Vector movement  

    //TODO Add a teardown method 
    //TODO Add 1 method to call everything that happens in 1 round


    /********************************************/
    /********  Public Variables  ****************/
    /********************************************/    
    public Canvas background;//Parent class for the map
    public Camera cam;//main camera
    public RawImage map;//the map image
    public RawImage pin;//The real location pin
    public Button conf;//Confirm button placed underneath the guess
    public RawImage pinLocked;//Mirror of pin but with pink color
    public Image randomImageToGuess;//Contains a random image from a list that the user must guess its location    
    public List<Sprite> images;//List containing all the images that get displayed that the user must guess    
    public Text scoreText;//Contains the current score of the player, initialy starts at 00000
    public Text roundText;//Contains the current round of the player / the total round; ex 1/3 == round 1 of 3

    /********************************************/
    /***************   Flags  *******************/
    /********************************************/
    private bool pinCreate;//Flag for creating pin, true==pin on screen false==no pins.
    private bool locked;//If true the guess is locked in and no more guesses allowed.
    private bool clickable;//Set to false while a picture is shown on screen then true once you can click

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
    private float waitTime = 5.0f; // Float for how long the picture stays up on the screen(in seconds)
    private float watchScoreTime = 2f;//This is the wait time between loading up the next round, allowing the player to check their score
    private List<Sprite> imagesNoDup;//Same as other array except there are no duplicate pictures in thie array    

    /********************************************/
    /***********  Gameplay Related  *************/
    /********************************************/
    private float guessDistance;// Contains the distance of the users guess
    private float score; //Contains the current running score of the player
    private int maxRound = 3;//Contains the max rounds to be played for 1 match
    private int currentRound;//Holds the current round of the game



    void Start () {//sets flags      
              
        imagesNoDup = images;
        pinVec.x = pin.transform.position.x;
        pinVec.y = pin.transform.position.y;
        pinVec.z = 0;
        pinCreate = false;
        locked = false;
        clickable = false;
        currentRound = 1;

        showPicture();
        Invoke("removeOldImage",waitTime);//Invokes the method removeOldImage 'waitTime' from now
        Debug.Log("Setting clickable to:" + !clickable);
            
    }
    public void confirmLocation()//action listenere class called when confirm button clicked
    {        
        locked = true;        
        guessPin.texture = pinLocked.texture;
        Destroy(guessButton.gameObject);
        guessDistance = getDistance(pinVec, clickLocation);
        calculateScore();
       
    }


	void Update() //Check if click location is the same as the button location
    {
        
        if (Input.GetAxis("Mouse ScrollWheel")>0f)// Zoom with Scroll Wheel
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
        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == null && locked==false&&clickable==true)//== null means you clicked in the empty space and not the button
        {
            Debug.Log(EventSystem.current.currentSelectedGameObject);     
            clickLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickLocation.z = 0;
            clickLocation.y += 45;//Need to offset since the point is at the bottom of the image. Shift up to move the center of the image to the bottom point.
            createNewPin(clickLocation);
        }
       
    }
    
    public bool checkVector(Vector3 inputVector)//Returns true if the pin should be created within the playing area and false if the click is on the headers.
    {
        if (inputVector.y < -1580)
        {
            
            Debug.Log("Too Low");
            return false;
        }
        else if (inputVector.y > 1700)//If the location of the pin is covered by the header
        {
            
            Debug.Log("Too High");
            return false;

        }
        else return true;
    }
    public void createNewPin(Vector3 inputVector)//Create a pin at the x,y,z location
    {
        Debug.Log(checkVector(inputVector));
        
        
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
        Vector3 confirmVect = inputVector;

        if (inputVector.y < -1450)//If the location is too low we don't want to clip the confirm button.
        {
            confirmVect.y = inputVector.y + 150; //flip it so that the confirm button is on the top rather than below so it doesn't get clipped
        }        
        else//Offset and create
        {
            confirmVect.y = inputVector.y - 150;
        }

        guessButton.transform.SetParent(background.transform);
        guessButton.transform.position = confirmVect;
        guessButton.onClick.AddListener(confirmLocation);

        }
       
    }

    public void removeOldComponents()//cleanup the previous guesses.
    {
        Destroy(guessButton.gameObject);
        Destroy(guessPin.gameObject);

    }


    public float getDistance(Vector3 initial,Vector3 guess)//returns a float containing the distance between the guess and the real location
    {
        Debug.Log("INITIAL:"+initial.x + "," + initial.y);
        Debug.Log("GUESS:" +guess.x + "," + guess.y);       
        float distance = Vector3.Distance(initial, guess);
        Debug.Log("Distance: " + distance);

        return distance;
    }

    
    public void showPicture()//To make the picture dissapear move it behind the map, then to bring it back move it ahead.
    {
        Sprite rand = getRandomImage();
        newGuessImage = randomImageToGuess;
       
        newGuessImage = Instantiate(newGuessImage);


        newGuessImage.sprite = rand;//Sets the image to the random one from the array of images.
        
        newGuessImage.transform.SetParent(background.transform);       
        
    }

    public void removeOldImage()//deletes the duplicate image keeping the orignial
    {
        Debug.Log("Removing old image");       
        Destroy(newGuessImage.gameObject);
        clickable = true;

    }
    
    public Sprite getRandomImage()//Gets a random image from a secondary array, then removes this image from that array so that you can't get the same image twice
    {

        int count = imagesNoDup.Count;
        int index = Random.Range(0, count);
        Debug.Log("Selecting Image at index:" + index);
        Sprite currentImage = imagesNoDup[index];
        imagesNoDup.RemoveAt(index);//Remove the called image so that there is no repitition

        return currentImage;

    }
    
    private void calculateScore()//Since calculate score is at the end of the round, nextRound also gets invoked.
    {
        
        if (guessDistance < guessMinBuffer) //Small buffer to give a perfect score.
        {
            score = maxScore;
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

        Debug.Log("Your score is:" + scoreInt);
        Invoke("nextRound", watchScoreTime);


    }
    public void setRound(int roundNum,int totalRound)//Setter for the text box, roundNum is the current round and totalRound is the overal rounds
    {
        roundText.GetComponent<Text>().text = roundNum.ToString() + "/" + totalRound.ToString() ;
    }
    public void setScore(int newScore)//Changes how much score the player has
    {
        scoreText.GetComponent<Text>().text = newScore.ToString();
    }

    public void nextRound()//Load up the next image and play another round incrementing the round and score.
    {
        if(currentRound == maxRound)//Checks to see if the last round was just played
        {
            endGame();
        }
        currentRound += currentRound;
        showPicture();
        
        Invoke("removeOldImage", waitTime);//Invokes the method removeOldImage 'waitTime' from now
        Destroy(guessPin.gameObject);
        locked = false;//reset the clicking on the screen
        pinCreate = false;
        setRound(currentRound, maxRound);
        Debug.Log("Setting clickable to:" + !clickable);
        
       
    }
    public void endGame()//Called once the max rounds have been played.
    {

    }

}
