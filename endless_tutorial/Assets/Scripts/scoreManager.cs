using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour {
    public Text scoreText;
    public Text highScore;
    public float scoreCount;
    public float highScoreCount;
    public float pointForScore;
    public bool scoreIncreasing;
    public Text contador;
    public int botellas;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreIncreasing){
            scoreCount += pointForScore * Time.deltaTime;
        }
        if(scoreCount > highScoreCount){
            highScoreCount = scoreCount;
        }

        scoreText.text = "Distancia: " + Mathf.Round(scoreCount);
        if (Mathf.Round(scoreCount)>=150){
            SceneManager.LoadScene("sandias", LoadSceneMode.Single);
        }

        highScore.text = "Distancia Max: " + Mathf.Round(highScoreCount);

        contador.text = "Botellas: " + botellas;

	}
    public void addScore(int pointstoadd){
        botellas += pointstoadd;
    }
}
