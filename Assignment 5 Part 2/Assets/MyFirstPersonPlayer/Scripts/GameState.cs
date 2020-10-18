/*
 * Logan Ross
 * Assignment 5
 * tracks if the game is over
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public bool gameOver = false;
    public bool won = false;
    public Text uiGameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && won)
        {
            uiGameOver.text = "You Win!";
        }
    }
}
