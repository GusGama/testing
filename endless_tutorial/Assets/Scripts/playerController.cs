﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float moveSpeed;
    public float jumpForce;
    public float jumpTime;
    private float jumpTimeCounter;
    public float speedMultiplier;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    Touch toque;
    private Rigidbody2D myRb;
    public bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsground;
    private Collider2D myC;
    private Animator myAnim;
	// Use this for initialization
	void Start () {
        myRb = GetComponent<Rigidbody2D>();
        myC = GetComponent<Collider2D>();
        myAnim = GetComponent<Animator>();
        jumpTimeCounter = jumpTime;
        speedMilestoneCount = speedIncreaseMilestone;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0){
            toque = Input.GetTouch(0);
        }
        if(toque.phase == TouchPhase.Began){
            Debug.Log("toca");
        }
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsground);
        //grounded = Physics2D.IsTouchingLayers(myC, whatIsground);
        if(transform.position.x > speedMilestoneCount){
            speedMilestoneCount += speedIncreaseMilestone;
            speedIncreaseMilestone += speedIncreaseMilestone * speedMultiplier;
            moveSpeed = moveSpeed * speedMultiplier;
        }

        myRb.velocity = new Vector2(moveSpeed, myRb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || toque.phase == TouchPhase.Began) 
        {
            if (grounded)
            {
                myRb.velocity = new Vector2(myRb.velocity.x, jumpForce);
            }
        }
        if(Input.GetKey(KeyCode.Space) || toque.phase == TouchPhase.Began)
        {
            if(jumpTimeCounter > 0){
                myRb.velocity = new Vector2(myRb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }

        }
        if (Input.GetKeyUp(KeyCode.Space) || toque.phase == TouchPhase.Began)
        {
            jumpTimeCounter = 0; 
        }
        if(grounded){
            jumpTimeCounter = jumpTime;
        }
        myAnim.SetFloat("speed", myRb.velocity.x);
        myAnim.SetBool("grounded", grounded);
	}
}
