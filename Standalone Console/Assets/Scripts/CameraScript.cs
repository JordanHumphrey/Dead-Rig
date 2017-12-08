//using Assets.Scripts.World;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    //rigid body for the Ship Object
    public static Rigidbody rb;

    //holds rotation for where ship is looking
    private Vector3 Rotation;

    //passVariableTestExample
    /*
    private int currentScore;
    public void test(int score){
      currentScore += score;
      print("SCORE: " + currentScore);
    }
    */

    //MoveRightSquareText
    public bool MoveCameraUpBool;

    // Use this for initialization
    void Start ()
    {

        //gets the rigid bosy of the Ship
        rb = GetComponent<Rigidbody>();

    }

    public void MoveCameraUp()
    {
      transform.Translate (0,2,-1);
      transform.Rotate(new Vector3(20,0,0));
  }
    public void MoveCameraDown()
    {
      transform.Rotate(new Vector3(-20,0,0));
      transform.Translate (0,-2,1);

    }
}
