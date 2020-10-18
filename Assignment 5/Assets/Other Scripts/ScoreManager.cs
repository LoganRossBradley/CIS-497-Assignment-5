using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text uiScore;
    public Text uiGameOver;
    public bool gameOver;
    public bool won;

    // Start is called before the first frame update
    void Start()
    {
         score = 0;
        gameOver = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        uiScore.text = "Score: " + score;

        if (gameOver)
        {
            if (won)
            {
                uiGameOver.text = "You win! \n Press R to play again";
            }
            else
            {
                uiGameOver.text = "You Lose. \n Press R to try again";
            }
        }

        if(gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
