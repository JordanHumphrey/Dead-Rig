using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class MoveLeftSquare : MonoBehaviour
{
  //MoveRightSquare
  private ControlsScript controlsScript;
  public AudioSource audio;
  public Material[]materials;
  private Renderer rend;
  private int index = 1;
void Start()
{
  controlsScript = GameObject.FindObjectOfType<ControlsScript>();
  rend = GetComponent<Renderer>();//gives functionality for the renderer
  rend.enabled = true;//makes the rendered 3d object visible if enabled
}
void Update()
{
  if(materials.Length == 0)
  {
    return;
  }
  if ((Input.GetKey("z")))
  {
    audio.Play();
    rend.sharedMaterial = materials[1];
    controlsScript.MoveLeftSquare();
    //print(index);//used for debugging
  }
  else
  {
    rend.sharedMaterial = materials[0];
    //print (index); //used for debugging
  }
}
}
