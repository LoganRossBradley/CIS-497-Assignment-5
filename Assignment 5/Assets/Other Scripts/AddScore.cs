using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    bool triggered = false;
    private  ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        sm = GameObject.FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            Console.WriteLine("gem got");
            sm.score++;
        }
    }
}
