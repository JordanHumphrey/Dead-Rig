﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clawClose1 : MonoBehaviour {
    
    private bool lowerLimit,upperLimit = false;



    


    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        
        /*HingeJoint hinge = GetComponent<HingeJoint>();

        if (Input.GetKey("q"))
        {
            hinge.useMotor = true;
        }
        */
        



       if (movement.close1 && lowerLimit == false)
        {
            upperLimit = false;
            
            transform.Rotate(0, 0, -15);
            
        }

        if(movement.close1 == false && upperLimit == false )
        {
            movement.close1 = false;
            lowerLimit = false;
            transform.Rotate(0, 0, +15);
          
        }

        if (transform.rotation.z <= -.1)
        {
            lowerLimit = true;
        }

        if (transform.rotation.z >= .4559173)
        {
            upperLimit = true;
        }
		
    }

    private void OnCollisionEnter(Collision collision)
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;
        if(collision.gameObject.tag == "debris")
        {
            Debug.Log("hit the debirs in pivot");
            motor.force = 0;
        }
    }
}
