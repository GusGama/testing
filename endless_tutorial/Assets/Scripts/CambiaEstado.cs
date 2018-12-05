using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaEstado : MonoBehaviour {
    public GameObject obj;
    private Animator anim;
    public string nombre_anim;
	// Use this for initialization
	void Start () {
        anim = obj.GetComponent<Animator>();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "desecho")
        {
            anim.SetBool(nombre_anim, true);
        }
    }
}
