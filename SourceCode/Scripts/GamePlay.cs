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
    




    public Canvas background;//Parent class for the map
    public Camera cam;//main camera
    public RawImage map;//the map image
    public RawImage pin;//The real location pin
    public Button conf;//Confirm button placed underneath the guess
    public RawImage pinLocked;//Mirror of pin but with pink color
    public Image randomImageToGuess;//Contains a random image from a list that the user must guess its location
    
   
    private bool pinCreate;//Flag for creating pin, true==pin on screen false==no pins.
    private bool locked;//If true the guess is locked in and no more guesses allowed.

    private Button guessButton;//Confirm button for when making a guess
    private RawImage guessPin;//holds the pink texture of the pin
    private Image newGuessImage;//Contains the new created duplicate of the placeHolder image.

    private Vector3 pinVec; // Vector for the pin
    private Vector3 clickLocation;//Vector for holding the x,y,z location of the mouse click

    private float waitTime = 5.0f; // Float for how long the picture stays up on the screen(in seconds)





    void Start () {//sets flags      

        pinVec.x = pin.transform.position.x;
        pinVec.y = pin.transform.position.y;
        pinVec.z = 0;
        pinCreate = false;
        locked = false;

        showPicture();
        Invoke("removeOldImage",waitTime);//Invokes the method removeOldImage 'waitTime' from now
        
    }
    public void confirmLocation()//action listenere class called when confirm button clicked
    {        
        locked = true;        
        guessPin.texture = pinLocked.texture;
        Destroy(guessButton.gameObject);
        float distance = getDistance(pinVec, clickLocation);
        //drawLine(pinVec, clickLocation);
        
    }


	void Update() //Check if click location is the same as the button location
    { 

        if (Input.GetAxis("Mouse ScrollWheel")>0f)// Zoom with Scroll Wheel
        {
            if ((cam.orthographicSize - 150 > 0))//Need to make sure you can't zoom in past the image.
                {
                cam.orthographicSize -= 150;
                }  
        }
        // Scoll back
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            cam.orthographicSize += 150f;   

        }
        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == null && locked==false)//== null means you clicked in the empty space and not the button
        {
                       
            clickLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickLocation.z = 0;
            clickLocation.y += 45;//Need to offset since the point is at the bottom of the image. Shift up to move the center of the image to the bottom point.
            createNewPin(clickLocation);
            
        }
       
    }
    

    public void createNewPin(Vector3 inputVector)//Create a pin at the x,y,z location
    {
        if (pinCreate)//Remove the old button
        {
            removeOldComponents();//make sure there is only ever one pin on the screen at a time
        }
        pinCreate = true;//After the 1st iteration pinCreate will always be true


        guessButton = Instantiate(conf);
        guessPin = Instantiate(pin);
        guessPin.transform.SetParent(background.transform);      
        guessPin.transform.position = inputVector;
        Vector3 confirmVect=inputVector;
        

        if (inputVector.y < -1700)//If the location is too low we don't want to clip the confirm button.
        {
            confirmVect.y = inputVector.y + 150;
        }        
        else
        {
            confirmVect.y = inputVector.y - 150;
        }
        guessButton.transform.SetParent(background.transform);
        guessButton.transform.position = confirmVect;
        guessButton.onClick.AddListener(confirmLocation);


       
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
        newGuessImage = randomImageToGuess;
        newGuessImage = Instantiate(newGuessImage);
        newGuessImage.transform.SetParent(background.transform);       
       
    }

    public void removeOldImage()
    {
        Debug.Log("Removing old image");       
        Destroy(newGuessImage.gameObject);

    }


   
    
}
