using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SabiasQueCount : MonoBehaviour {
    public float scoreCount;
    public float pointForScore;
    public string destino;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreCount += pointForScore *Time.deltaTime;
        if (Mathf.Round(scoreCount) >= 15){
            SceneManager.LoadScene(destino, LoadSceneMode.Single);
        }
    }
}
