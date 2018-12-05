using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotellasCaer : MonoBehaviour {
    public GameObject obj;
    private Animator anim;
    private bool trigger;
    private Vector3 v;

    public float EPSILON { get; private set; }
    private Touch toque;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        v.x = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            toque = Input.GetTouch(0);
        }
        if (toque.phase == TouchPhase.Began)
        {
            Debug.Log("toca");
        }
        trigger = Input.GetKeyDown(KeyCode.Space);
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || (System.Math.Abs(Input.acceleration.x) > EPSILON) || toque.phase == TouchPhase.Began)
        {
            Instantiate(obj, transform.position, transform.rotation);

        }
       
        anim.SetBool("trigger", trigger);
    }
}
