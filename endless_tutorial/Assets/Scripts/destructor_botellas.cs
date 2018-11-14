using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructor_botellas : MonoBehaviour {
    public GameObject DestructionPoint;
    public GameObject miserias;
    // Use this for initialization
    void Start () {
        DestructionPoint = GameObject.Find("destructor");
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < DestructionPoint.transform.position.y)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            Instantiate(miserias, transform.position, transform.rotation);
        }
    }
}
