using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public GameObject crane;

    public float speed;

    Vector3 originalPosition;

    public static bool close1 = false; //false = do not close yet

    static public bool set = false;


    public static bool highEnough = false;

    static public int control = 1;




    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 newPosition = crane.transform.position;


        originalPosition = new Vector3(crane.transform.position.x, 133.9f, crane.transform.position.z);



        Vector3 floor = new Vector3(0, 60, 0);

        if (control == 1)
        {

            set = true;

            if (Input.GetKey("w"))
            {
                newPosition.z--;
                crane.transform.position = newPosition;
            }

            if (Input.GetKey("s"))
            {
                newPosition.z++;
                crane.transform.position = newPosition;
            }

            if (Input.GetKey("a"))
            {
                newPosition.x++;
                crane.transform.position = newPosition;
            }

            if (Input.GetKey("d"))
            {
                newPosition.x--;
                crane.transform.position = newPosition;
            }
            if (Input.GetKey("space"))  //this is what brings the crane downward
            {
                control = 2;


            }

            /*
            if (Input.anyKey == false)
            {
                
                if (newPosition.y != originalPosition.y)
                {
                    newPosition.y++;
                    crane.transform.position = newPosition;
                }
            }
            */
            if (newPosition.y == originalPosition.y && set == true)
            {

                //close1 = false;  //open arms once in position
                set = false;
            }


        }

        if (control == 2)
        {

            if (crane.transform.position.y != 60);
            {
                newPosition.y--;
                crane.transform.position = newPosition;
            }

            if (crane.transform.position.y <= 50)
            {

                   close1 = true; //these close the arms by using static variables
                   control = 3;
            }


        }

        if (control == 3)
        {
           
            if (newPosition.y != 133.9)
            {

                newPosition.y++;
                crane.transform.position = newPosition;

                if (newPosition.y == originalPosition.y)
                {
                    highEnough = true;
                }

                /* if (newPosition.x < -139)
                 {
                     if(newPosition.x != -139.6) //-139.6 is the original x
                     {
                     Debug.Log("trying to go back");
                     newPosition.x++;
                     crane.transform.position = newPosition;
                     }                    
                 }
                 else if (newPosition.x > -139.6)
                 {

                 if(newPosition.x != -139.6) //-139.6 is the original x
                     {
                     Debug.Log("trying to go back");
                     newPosition.x--;
                     crane.transform.position = newPosition;
                     }
                  }

                 if (newPosition.z < -172)
                 {
                  Debug.Log("trying to go back");
                  newPosition.z++;
                  crane.transform.position = newPosition;
                 }
                 else if (newPosition.z > -172)
                 {
                     Debug.Log("trying to go back number 2");
                     newPosition.z--;
                     crane.transform.position = newPosition;
                 }
             }
             */

                if (newPosition.y == originalPosition.y)
                {
                    set = true;
                    Debug.Log("control is trying to go 1");
                    control = 1;
                }


            }
        }

    }
}


    





