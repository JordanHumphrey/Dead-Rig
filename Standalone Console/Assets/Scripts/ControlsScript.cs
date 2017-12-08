//using Assets.Scripts.World;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ControlsScript : MonoBehaviour
{
    //rigid body for the Ship Object
    public static Rigidbody rb;

    public int GameArea;

    public int RotationSpeed;

    //hold pause menu object
    //public Transform PauseMenu;

    //holds rotation for where ship is looking
    private Vector3 Rotation;

    //for music and audio effects inside ship
    public AudioClip[] AudioEffect;
    public AudioSource source;
    //passVariableTestExample
    public GameObject console;
    private int currentScore;
    public void test(int score){
      currentScore += score;
      print("SCORE: " + currentScore);
    }
    

    // Use this for initialization
    void Start ()
    {
        
//game starts looking at the middle area
        GameArea = 1;

        RotationSpeed = 100;

        //gets the rigid bosy of the Ship
        rb = GetComponent<Rigidbody>();

        //makes sure pause menu is inactive
        //PauseMenu.gameObject.SetActive(false);

    }

	// Update is called once per frame
	void Update ()
    {

        //move tco area to the Right area
        /*if ((Input.GetKey("x")))
        {
            transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
        }

        //move to area to the Left area
        if ((Input.GetKey("z")))
        {
            transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime) * -1);
        }
        */
        /*
        //if looking at the Middle area
        if (GameArea == 1)
        {
            //move to area to the Left area
            if ((Input.GetKey("z")))
            {
                //GameArea = 0; //set are back to center
                //transform.Rotate(new Vector3(0,-90,0));

                transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
            }

            //move to area to the right area
            if ((Input.GetKey("x")))
            {
                //GameArea = 2; //set area to right
                //transform.Rotate(new Vector3(0, 90, 0));

                transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
            }
        }

        //if looking at the Left area
        else if (GameArea == 0)
        {
            //move back to the middle area
            if ((Input.GetKey("x")))
            {
                GameArea = 1; //set are back to center
                transform.Rotate(new Vector3(0, 0, 0));
            }
        }

        //if looking at the Right area
        else if (GameArea == 2)
        {
            //move back to the middle area
            if ((Input.GetKey("z")))
            {
                GameArea = 1; //set are back to center
                transform.Rotate(new Vector3(0, 0, 0));
            }
        }
        */
    }
    public void MoveRightSquare()
    {
      transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
      //transform.Rotate(new Vector3(0,-90,0));
  }
    public void MoveLeftSquare()
    {
         transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime) * -1);
    }
}
