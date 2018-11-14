using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botellaDesaparece : MonoBehaviour {
    public bool visible;
    private Rigidbody2D myRb;
    private Collider2D myC;
    public LayerMask isTouching;
	// Use this for initialization
	void Start () {
        myRb = GetComponent<Rigidbody2D>();
        myC = GetComponent<Collider2D>();
        visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        
		visible = Physics2D.IsTouchingLayers(myC, isTouching);
        if(visible){
            gameObject.SetActive(false);
        }
    }
}
