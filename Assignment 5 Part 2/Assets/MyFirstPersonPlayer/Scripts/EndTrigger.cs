/*
 * Logan Ross
 * Assignment 5
 * final trigger for ending the game
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private bool triggered = false;
    public GameState gs;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gs.gameOver = true;
            gs.won = true;
        }
    }
}
