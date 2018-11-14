using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotellasCaer : MonoBehaviour {
    public GameObject obj;
    private Animator anim;
    private bool trigger;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        trigger = Input.GetKeyDown(KeyCode.Space);
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(obj, transform.position, transform.rotation);

        }
       
        anim.SetBool("trigger", trigger);
    }
}
