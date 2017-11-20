using UnityEngine;
using System.Collections;

public class DesignChangingSquareTwo : MonoBehaviour {
  public Material[]materials;//allows input of material colors in a set sized array
  public Renderer rend;//what are we rendering? The sphere.
  public static int indexTwo = 0;//initialize at 1, otherwise you have to press the ball twice to change color at first
  void Start (){
    rend = GetComponent<Renderer>();//gives functionality for the renderer
    rend.enabled = true;//makes the rendered 3d object visible if enabled
  }
  void OnMouseDown(){
      if(materials.Length == 0){ //if there are no materials present, nothing happens.
        return;
      }
      if(Input.GetMouseButtonDown(0)) {
        indexTwo += 1; //when mouse is pressed down we increment up to the next index location
      if(indexTwo == materials.Length + 1){ //when it reaches he end of materials it starts over
        indexTwo = 1;
      }
      print (indexTwo); //used for debugging
      rend.sharedMaterial = materials[indexTwo - 1]; //this sets the material color values inside the index.
    }
  }
}
