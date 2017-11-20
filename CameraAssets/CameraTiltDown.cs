using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTiltDown : MonoBehaviour {

    //Variables
    public float rotateSpeed = 80.0F;                                                   //Rotating speed of the camera. Set in Unity
    public float rotateAngle = 90.0F;                                                   //Angle to rotate to
    bool tiltingCam = false;                                                            //Is the camera currently being tilted
    bool camTilted = false;                                                             //Is the camera tilted
    int reverseRotate = 1;                                                              //Reverses the speed of rotation to return to original position

    
    // Use this for initialization
    void Start () {
        float startAngleX = transform.rotation.eulerAngles.x;
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("camTilted = " + camTilted);
        //Debug.Log("transform.eulerAngles.x = " + transform.eulerAngles.x);
        //Debug.Log("camTilted = " + camTilted);
        //Debug.Log("tiltingCam = " + tiltingCam);
        Debug.Log("reverseRotate = " + reverseRotate);
        
        if (Input.GetKeyDown(KeyCode.V) && tiltingCam == false)
        {
            tiltingCam = true;
            cameraTilt();
        }
        if (tiltingCam == true)
        {

            if (camTilted == false)
            {
                cameraTilt();
            }
            if (camTilted == true)
            {
                cameraTilt();
            }
            if (transform.eulerAngles.x <= 360 && transform.eulerAngles.x > 270)     //If rotation enters 1st Quadrant
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                reverseRotate = 1;
                camTilted = false;
                tiltingCam = false;                                                             //*Current issue, rotates past
            }
            if (transform.eulerAngles.x >= 90 && transform.eulerAngles.x < 180)      //If rotation enters 3rd Quadrant
            {
                transform.eulerAngles = new Vector3(rotateAngle, 0, 0);
                reverseRotate = -1;
                camTilted = true;
                tiltingCam = false;
            }
        }
    }

    void cameraTilt()
    {
        //Gets the angle needed to rotate for each frame.(Angle, rotation angle desired, speed of the rotation)
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.x, rotateAngle, rotateSpeed * Time.deltaTime * reverseRotate);
        //Rotate by the calculated angle
        transform.eulerAngles = new Vector3(angle, 0, 0);
    }
}
