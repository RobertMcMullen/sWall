using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour {

    public Button done;//Button to return to the main menu
    public Button[] allButtons;//Required for the theming



	// Use this for initialization
	void Start () {
        Theme currentTheme = new Theme();
        currentTheme.updateColors(allButtons, null);
        done.onClick.AddListener(returnMainMenu);
    }
	
	private void returnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
