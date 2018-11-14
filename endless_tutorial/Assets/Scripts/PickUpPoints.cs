using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour {
    public int scoreToGive;

    private scoreManager theScoreManager;

	// Use this for initialization
	void Start () {

        theScoreManager = FindObjectOfType<scoreManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "jones"){
            theScoreManager.addScore(scoreToGive);
            gameObject.SetActive(false);
        }
    }

}
