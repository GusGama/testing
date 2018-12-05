using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class avanza_Imagenes : MonoBehaviour {
    public int numImagen;
    public GameObject obj1;
    public GameObject obj2;
	// Use this for initialization
	void Start () {
        numImagen = 0;

	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.Space)){
            numImagen += 1;
        }
        if (numImagen == 0)
        {
            obj1.SetActive(true);
        }
        else if (numImagen == 1)
        {
            obj1.SetActive(false);
            obj2.SetActive(true);
        } else{
            SceneManager.LoadScene("3.runer", LoadSceneMode.Single);
        }
	}
}
