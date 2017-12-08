using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpSquare : MonoBehaviour {
    private CameraScript camerascript;
    public AudioSource audioUp;
    public AudioSource audioDown;
    public Material[]materials;
    private Renderer rend;
    public int Location;
    float t;
    Vector3 startPosition;
    Vector3 target;
    float timeToMove;


    // Use this for initialization
    void Start () {
        camerascript = GameObject.FindObjectOfType<CameraScript>();
        rend = GetComponent<Renderer>();//gives functionality for the renderer
        rend.enabled = true;//makes the rendered 3d object visible if enabled
        Location = 0;
        startPosition = target = transform.position;


    }

	// Update is called once per frame
	void Update () {
        if(materials.Length == 0)
        {
          return;
        }
        if (Input.GetKeyDown("x") && Location == 0)
        {
            audioUp.Play();
            rend.sharedMaterial = materials[1];
            camerascript.MoveCameraUp();
            Debug.Log("Move to upper position.");
            Location = 1;
            //print(index);//used for debugging
        }

        else if (Input.GetKeyDown("x") && Location == 1)
        {
            audioDown.Play();
            rend.sharedMaterial = materials[0];
            camerascript.MoveCameraDown();
            Debug.Log("Move to lower position.");
            Location = 0;
        }
    }
/*
    public IEnumerator MoveToPosition(Transform transform, Vector3 position)
    {
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }
*/
}
