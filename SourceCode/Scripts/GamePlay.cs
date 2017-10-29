using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Robert McMullen 100977031
//sWall Game/Activity


public class GamePlay : MonoBehaviour {
    //TODO Add panning/camera movement
    //TODO Add touchScreen Vector movement
    //TODO Add main menu
    //TODO add scoring system
    //TODO Confirm shouldn't clip the side of the screen

        

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
    private float waitTime = 1.0f; // Float for how long the picture stays up on the screen(in seconds)
    private List<Sprite> imagesNoDup;//Same as other array except there are no duplicate pictures in thie array

    /********************************************/
    /***********  Gameplay Related  *************/
    /********************************************/
    private float guessDistance;// Contains the distance of the users guess
    private float score;  



    void Start () {//sets flags      
              
        imagesNoDup = images;
        pinVec.x = pin.transform.position.x;
        pinVec.y = pin.transform.position.y;
        pinVec.z = 0;
        pinCreate = false;
        locked = false;
        clickable = false;    

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
        //drawLine(pinVec, clickLocation);
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

    public void drawLine(Vector3 a,Vector3 b)//Draws a line between points a and b
    {
        //TODO line rendere could be a good possibility
        LineRenderer line_1;
        LineRenderer line = new LineRenderer();
        line.gameObject.SetActive(true);
        line.SetVertexCount(2);
        line.SetPosition(0, a);
        line.SetPosition(1, b);

    }

    public void showPicture()//To make the picture dissapear move it behind the map, then to bring it back move it ahead.
    {
        //Sprite rand = randomPic.getRandomImage();
        //Sprite rand = randomPic.getCurrentImage();
        //Sprite rand = images[0];
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
    
    public Sprite getRandomImage()
    {

        int count = imagesNoDup.Count;
        int index = Random.Range(0, count);
        Debug.Log("Selecting Image at index:" + index);
        Sprite currentImage = imagesNoDup[index];
        imagesNoDup.RemoveAt(index);//Remove the called image so that there is no repitition
        return currentImage;

    }
    
    private void calculateScore()
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
            score = maxScore - guessDistance;
        }
        Debug.Log("Your score is:" + score);

    }

}
