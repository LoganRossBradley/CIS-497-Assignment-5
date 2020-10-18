using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public ScoreManager sm;
	// Start is called before the first frame update
	void Start()
    {
        
    }

	void OnTriggerEnter2D(Collider2D theCollider)
	{
		if (theCollider.CompareTag("Player"))
		{
			sm.gameOver = true;
			sm.won = true;
		}
	}
}
