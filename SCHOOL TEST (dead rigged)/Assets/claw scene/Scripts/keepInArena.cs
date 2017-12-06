using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepInArena : MonoBehaviour {
    
    



    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("tried to destroy out of bounds");
        
        Destroy(collision.gameObject);
        spawner.count--;
    }
}
