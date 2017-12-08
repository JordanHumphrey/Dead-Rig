using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ArrowKeyRight : MonoBehaviour
{
  public AudioSource audio;
  public Material[]materials;
  private Renderer rend;
  private int index = 1;
void Start()
{
  rend = GetComponent<Renderer>();//gives functionality for the renderer
  rend.enabled = true;//makes the rendered 3d object visible if enabled
}
void Update()
{
  if(materials.Length == 0)
  {
    return;
  }
  if ((Input.GetKey("d")))
  {
    audio.Play();
    rend.sharedMaterial = materials[1];
    //print(index);//used for debugging
  }
  else
  {
    rend.sharedMaterial = materials[0];
    //print (index); //used for debugging
  }
}
}
