using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour {

    


    // Use this for initialization
    void Start () {
        
        

    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey("e") && movement.control == 1)  //this is what breaks the fixed joint (drop) , may want to call this as long as the UI button is pressed rather than just once.
        {
            movement.close1 = false;
            FixedJoint removeFixedJoint = GetComponent<FixedJoint>();
            Destroy(removeFixedJoint);
            
            
        }

        


    }



    private void OnCollisionEnter(Collision collision)
    {
        var joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = collision.rigidbody;
        
        
    }
}
