using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clawClose2 : MonoBehaviour {
    private bool lowerLimit, upperLimit = false;

    
    

    // Use this for initialization
    void Start () {
        



    }
	
	// Update is called once per frame
	void Update () {
        /*
        HingeJoint hinge = GetComponent<HingeJoint>();

        if (Input.GetKey("q"))
        {
            hinge.useMotor = true;
        }
        */
         
        
        if(movement.close1 && lowerLimit == false)
        {
            upperLimit = false;
            transform.Rotate(0, 0, +15);
        }

        if(movement.close1 == false && upperLimit == false)
        {
            lowerLimit = false;
            transform.Rotate(0, 0, -15);
        }

        if(transform.rotation.z >= 0.1253231)
        {
            lowerLimit = true;
        }

        if(transform.rotation.z <= -0.3651141)
        {
            upperLimit = true;
        }
		
	}
}
