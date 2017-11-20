using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{

    //Variables
    public GameObject focusObj;                                       //Game object reference
    private Vector3 offset;                                         //Holds offset

    // Use this for initialization
    void Start()
    {
        offset = transform.position - focusObj.transform.position;    //Get the offset position of the camera from the focusObj
    }

    // LateUpdate is called after all processes are run and updated (after focusObj moves)
    void LateUpdate()
    {
        transform.position = focusObj.transform.position + offset;    //Move camera to the new offset position
    }
}
