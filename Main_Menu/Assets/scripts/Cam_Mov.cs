using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Mov : MonoBehaviour
{

    public float horizontalSpeed = 40.0f;
    public float verticleSpeed = 40.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
