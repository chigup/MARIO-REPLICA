using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {



    public Rigidbody player;
    public Animator anim;
    public float walkToRun = .9f;
    public float accleration = 2f;
    private bool isRunning=false;
    private bool isWalking;
    public float speed = 3;
    public float jumpForce = 2f;
    private bool isgrounded = true;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(verti, 0, hori) * speed;
        player.transform.Translate(movement);
      
        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W))
        {
            player.velocity = movement * accleration;
            isRunning = true;
            isWalking = false;
            anim.SetBool("isRunning", isRunning);

        }
      
         
    }
}
