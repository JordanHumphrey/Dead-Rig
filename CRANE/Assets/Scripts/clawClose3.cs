using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clawClose3 : MonoBehaviour {
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
        


        if(Input.GetKey("q") && lowerLimit == false)
        {
            upperLimit = false;
            transform.Rotate(-10, 0,0);
        }
        if(Input.GetKey("e") && upperLimit == false)
        {
            lowerLimit = false;
            transform.Rotate(+10, 0, 0);
        }



        if(transform.localRotation.x >= 0.3826034)
        {
            upperLimit = true;
        }

        if(transform.localRotation.x <= -0.0871557)
        {
            lowerLimit = true;
        }
        
    }
}
