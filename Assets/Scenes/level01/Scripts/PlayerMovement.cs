﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWaysForce= 500f;


	void FixedUpdate () {
      
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
