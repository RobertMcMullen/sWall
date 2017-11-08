using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game  {
    //Game class will keep track of the score and rounds etc.

    /********************************************/
    /********  Class References  ****************/
    /********************************************/
    private GamePlay gp;

    /********************************************/
    /********  Gameplay Options  ****************/
    /********************************************/
    private int totalRounds = 3;//this will contain the total number of rounds to be played for 1 match


    /********************************************/
    /**********  Running Values  ****************/
    /********************************************/
    private int Score;//contains the running score of the player during the match of X rounds
    private int roundNum;//The current round the player is on.


	// Use this for initialization
	void Start () {
		
	}


    public void createNewGame(int maxRounds)//Creates a new game with a specific amount of rounds
    {
        if(maxRounds == 0)//if the input is 0 then the game will default the amount of rounds.
        {
            maxRounds = totalRounds;
        }
        //gp = new GamePlay();
       // gp.setRound(1, maxRounds);
        //gp.setScore(00000);
    }
   
}
