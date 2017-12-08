using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallButton : MonoBehaviour {
    public AudioSource rollballControl;
    public Material[]materials;
    private Renderer rend;

    // Use this for initialization
    void Start () {
      rend = GetComponent<Renderer>();//gives functionality for the renderer
      rend.enabled = true;//makes the rendered 3d object visible if enabled
    }

	  // Update is called once per frame
    void Update () {
        if(materials.Length == 0)
        {
          return;
        }
        if (Input.GetKeyDown("2"))
        {
            rollballControl.Play();
            rend.sharedMaterial = materials[1];
            /**************************************/
            //update public variable HERE
            /**************************************/
            Debug.Log("RollBallMode");
        }

        else if (Input.GetKeyDown("1"))
        {
            rend.sharedMaterial = materials[0];
            /**************************************/
            //update public variable HERE
            /**************************************/
            Debug.Log("NoRollBallMode");
        }
    }
}
