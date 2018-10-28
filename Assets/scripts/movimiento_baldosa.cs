using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_baldosa : gravity {
    public float maxSpeed = 7;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 move = Vector2.zero;

        //move.x = Input.GetAxis("Horizontal");
        move.x = move.x - maxSpeed;
    }
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        //move.x = Input.GetAxis("Horizontal");
        move.x = move.x - maxSpeed;
        //if (Input.GetButtonDown("Jump") && grounded)
        

        //bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        //if (flipSprite)
        //{
        //    spriteRenderer.flipX = !spriteRenderer.flipX;
        //}

        //animator.SetBool("grounded", grounded);
        //animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }
}
