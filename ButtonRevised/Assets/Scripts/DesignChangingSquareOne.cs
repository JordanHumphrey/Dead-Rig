using UnityEngine;
using System.Collections;

public class DesignChangingSquareOne : MonoBehaviour {
  public Material[]materials;//allows input of material colors in a set sized array
  public Renderer rend;//what are we rendering? The sphere.
  public static int indexOne = 1;//initialize at 1, otherwise you have to press the ball twice to change color at first
  void Start (){
    rend = GetComponent<Renderer>();//gives functionality for the renderer
    rend.enabled = true;//makes the rendered 3d object visible if enabled
  }
  void OnMouseDown(){
      if(materials.Length == 0){ //if there are no materials present, nothing happens.
        return;
      }
      if(Input.GetMouseButtonDown(0)) {
        indexOne += 1; //when mouse is pressed down we increment up to the next index location
      if(indexOne == materials.Length + 1){ //when it reaches he end of materials it starts over
        indexOne = 1;
      }
      print (indexOne); //used for debugging
      rend.sharedMaterial = materials[indexOne - 1]; //this sets the material color values inside the index.
    }
  }
}
