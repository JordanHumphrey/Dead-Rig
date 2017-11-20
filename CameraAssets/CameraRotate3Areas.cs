using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate3Areas : MonoBehaviour
{
    //Variables
    public float rotateSpeed = 80.0F;                                                   //Rotating speed of the camera. Set in Unity
    public float rotateAngleA = 0.0F;                                                   //Angle at area A camera rotates to
    public float rotateAngleB = 120.0F;                                                 //Angle at area A camera rotates to
    public float rotateAngleC = 240.0F;                                                 //Angle at area A camera rotates to
    bool rotatingCamLeft = false;                                                       //Is the camera currently being rotated left
    bool rotatingCamRight = false;                                                      //Is the camera currently being rotated right
    bool camRotatedAreaA = false;                                                       //Is the camera in area A
    bool camRotatedAreaB = false;                                                       //Is the camera in area B
    bool camRotatedAreaC = false;                                                       //Is the camera in area C
    int reverseRotate = 1;                                                              //Reverses the speed of rotation to return to original position
    float areaMargin = 1;   //NOTE: Adjust depending on speed. Code may need to be adjusted similar to case AreaB if unable to rotate from a position

    // Use this for initialization
    void Start()
    {
        float startAngleX = transform.rotation.eulerAngles.x;
        float startAngleY = transform.rotation.eulerAngles.y;
        float startAngleZ = transform.rotation.eulerAngles.z;
        transform.eulerAngles = new Vector3(0, rotateAngleA, 0);                        //Set the camera to Angle A at the begining
        camRotatedAreaA = true;                                                         //Set the camRotatedArea to true

    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("rotatingCamRight = " + rotatingCamRight);
        Debug.Log("rotatingCamLeft = " + rotatingCamLeft);
        Debug.Log("camRotatedAreaA = " + camRotatedAreaA);
        Debug.Log("camRotatedAreaB = " + camRotatedAreaB);
        Debug.Log("camRotatedAreaC = " + camRotatedAreaC);*/
        //Debug.Log("transform.eulerAngles.y = " + transform.eulerAngles.y);
        //cameraRotateToAngleA();

        //Get the Keypress
        if (Input.GetKeyDown(KeyCode.LeftArrow) && rotatingCamRight == false && rotatingCamLeft == false)
        {
            rotatingCamLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && rotatingCamLeft == false && rotatingCamRight == false)
        {
            rotatingCamRight = true;
        }

        //Rotate to the correct area based on current location
        if (rotatingCamLeft == true)
        {
            if (camRotatedAreaA == true)
            {
                cameraRotateToAngleC();
            }
            else if (camRotatedAreaB == true)
            {
                cameraRotateToAngleA();
            }
            else if(camRotatedAreaC == true)
            {
                cameraRotateToAngleB();                                                 //Comment out to lock out rotating from Area C to B
            }
        }
        else if (rotatingCamRight == true)
        {
            if (camRotatedAreaA == true)
            {
                cameraRotateToAngleB();
            }
            else if (camRotatedAreaB == true)
            {
                cameraRotateToAngleC();                                                 //Comment out to lock out rotating from Area B to C
            }
            else if (camRotatedAreaC == true)
            {
                cameraRotateToAngleA();
            }
        }

        //When in the area set values
        if (transform.eulerAngles.y == rotateAngleA)
        {
            //Debug.Log("         ENTERED AREA A");
            camRotatedAreaA = true;
            camRotatedAreaB = false;
            camRotatedAreaC = false;
            rotatingCamLeft = false;
            rotatingCamRight = false;
            transform.eulerAngles = new Vector3(0, rotateAngleA, 0);

        }
        if (transform.eulerAngles.y >= (rotateAngleB - areaMargin) && transform.eulerAngles.y <= (rotateAngleB + areaMargin))
        {
            //Debug.Log("         ENTERED AREA B");
            camRotatedAreaA = false;
            camRotatedAreaB = true;
            camRotatedAreaC = false;
            rotatingCamLeft = false;
            rotatingCamRight = false;
            transform.eulerAngles = new Vector3(0, rotateAngleB, 0);

        }
        if (transform.eulerAngles.y == rotateAngleC)
        {
            //Debug.Log("         ENTERED AREA C");
            camRotatedAreaA = false;
            camRotatedAreaB = false;
            camRotatedAreaC = true;
            rotatingCamLeft = false;
            rotatingCamRight = false;
            transform.eulerAngles = new Vector3(0, rotateAngleC, 0);

        }

    }

    void cameraRotateToAngleA()
    {
        //Gets the angle needed to rotate for each frame.(Angle, rotation angle desired, speed of the rotation)
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, rotateAngleA, rotateSpeed * Time.deltaTime * reverseRotate);
        //Rotate by the calculated angle
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
    void cameraRotateToAngleB()
    {
        //Gets the angle needed to rotate for each frame.(Angle, rotation angle desired, speed of the rotation)
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, rotateAngleB, rotateSpeed * Time.deltaTime * reverseRotate);
        //Rotate by the calculated angle
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
    void cameraRotateToAngleC()
    {
        //Gets the angle needed to rotate for each frame.(Angle, rotation angle desired, speed of the rotation)
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, rotateAngleC, rotateSpeed * Time.deltaTime * reverseRotate);
        //Rotate by the calculated angle
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
}
