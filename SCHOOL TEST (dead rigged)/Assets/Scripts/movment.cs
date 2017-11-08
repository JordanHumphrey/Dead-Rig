using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {

    public GameObject crane;

    public float speed;

    Vector3 originalPosition;

    

    // Update is called once per frame
    void FixedUpdate() {
        originalPosition = new Vector3(crane.transform.position.x, 0, crane.transform.position.z);


        Vector3 newPosition = crane.transform.position;

        if (Input.GetKey("w"))
        {   
            newPosition.z++;
            crane.transform.position = newPosition;
        }

        if (Input.GetKey("s"))
        {   
            newPosition.z--;
            crane.transform.position = newPosition;
        }

        if (Input.GetKey("a"))
        {
            newPosition.x--;
            crane.transform.position = newPosition;
        }

        if (Input.GetKey("d"))
        {
            newPosition.x++;
            crane.transform.position = newPosition;
        }
        if (Input.GetKey("space"))
        {
            newPosition.y--;
            crane.transform.position = newPosition;  
        }
        if(Input.anyKey == false)
        {
            if(newPosition.y != originalPosition.y)
            {
                newPosition.y++;
                crane.transform.position = newPosition;
            }
        }
        
        
    }
}


