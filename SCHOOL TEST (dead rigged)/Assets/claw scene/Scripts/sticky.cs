using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour {
    



    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey("e"))
        {
            Debug.Log("trying to destroy");
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
