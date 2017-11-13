using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

    public Button increaseRounds;
    public Button decreaseRounds;
    public Button increaseTime;
    public Button decreaseTime;
    public Button done;
    public Text roundText;
    public Text timeText;


	// Use this for initialization
	void Start () {
        increaseRounds.onClick.AddListener(plusRoundsFunc);
        decreaseRounds.onClick.AddListener(decreaseRoundsFunc);
        increaseTime.onClick.AddListener(increaseTimeFunc);
        decreaseTime.onClick.AddListener(decreaseTimeFunc);
        done.onClick.AddListener(finished);
    }
    private void finished()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void plusRoundsFunc()
    {        
        GamePlay.maxRound += 1;
        updateRounds(GamePlay.maxRound);
    }
    private void decreaseRoundsFunc()
    {
        if (GamePlay.maxRound > 1)
        {
            GamePlay.maxRound -= 1;
            updateRounds(GamePlay.maxRound);
        }
        
    }
    private void increaseTimeFunc()
    {        
        GamePlay.waitTime += 1;
        changeTime(GamePlay.waitTime);
    }
    private void decreaseTimeFunc()
    {
        if (GamePlay.waitTime > 1)
        {
            GamePlay.waitTime -= 1;
            changeTime(GamePlay.waitTime);
        }
        
    }
    private void updateRounds(int rounds)
    {
        roundText.GetComponent<Text>().text = "Rounds: " + rounds.ToString();
    }
    private void changeTime(float time)
    {
        timeText.GetComponent<Text>().text = "View Time: "+ time.ToString()+"s";
    }

	
}
