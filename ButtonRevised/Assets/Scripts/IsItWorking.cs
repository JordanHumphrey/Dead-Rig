using UnityEngine;
using System.Collections;

public class IsItWorking: MonoBehaviour {
  public Material[]materials;//allows input of material colors in a set sized array
  public Renderer rend;//what are we rendering? The sphere.
void Start(){
  CheckForSuccess();
}

  void CheckForSuccess(){
    if((DesignChangingSquareZero.indexZero == 0)&&(DesignChangingSquareOne.indexOne == 2)&&(DesignChangingSquareTwo.indexTwo == 1)&&(DesignChangingSquareThree.indexThree == 3))
    {
        //loadGreenThing
    int life = 42;
    print(life);//used for debugging
      //rend.sharedMaterial = materials[indexOne - 1]; //this sets the material color values inside the index.
    }
  }
}
