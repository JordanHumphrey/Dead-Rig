using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        var joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = collision.rigidbody;
        if(Input.GetKey("e"))
        {
            Destroy(joint);
        }
    }
}
