using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour {
    //Main menu class for now has 3 buttons, play, options and how to play.
    //It will create a new instace of class 'Game' when play, Game keeps track of the score and rounds.
    

    /********************************************/
    /********  Public Variables  ****************/
    /********************************************/
    public Button play;//Play button that start the game when pressed
    public Button options;//Options button that bring up an options menu to change gameplay setting;
    public Button howToPlay;//On click it should either bring up instructions or launch a video
    public Button themeA;
    public Button themeB;
    public Button themeC;
    public Text version;//Contains the version number in the lower left corner should be changed either manually or through code when changes have been made
    public Button[] allButtons;//Contains a reference to all the buttons on the main menu

    private Theme currentTheme;
    

    void Start () {

        //initialize the actionListeners for all the buttons
        play.onClick.AddListener(launchGame);
        options.onClick.AddListener(openOptions);
        howToPlay.onClick.AddListener(openHowToPlay);

        currentTheme = new Theme();
        currentTheme.updateColors(allButtons, null);

        themeA.onClick.AddListener(delegate { updateTheme(0); });
        themeB.onClick.AddListener(delegate { updateTheme(1); });
        themeC.onClick.AddListener(delegate { updateTheme(2); });

            

    }   
	
    private void launchGame()
    {
       
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Themes" + "\\" + "Locations.xml";//Contains the path to myDocuments, will read the file that is in there
        Debug.Log(path);
        if (System.IO.File.Exists(path))//Check to see that the location folders exists before starting the game.
        {
            Debug.Log("Launching Game");
            SceneManager.LoadScene("GamePlayRound");
        }

    }
    private void openOptions()
    {
        Debug.Log("Opening options menu");
        SceneManager.LoadScene("options");
        
    }
    private void openHowToPlay()
    {
        Debug.Log("Opening Instructions");
        SceneManager.LoadScene("HowToPlay");
    }   

    private void updateTheme(int themeNum)
    {
        currentTheme.updateTheme(themeNum);
        currentTheme.updateColors(allButtons, null);
    }



}
