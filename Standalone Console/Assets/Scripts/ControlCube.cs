using UnityEngine;
using System.Collections;
public class ControlCube : MonoBehaviour {
  //Use this for initialization
  public float moveSpeed;
  void Start()
  {
      moveSpeed = 10f;
  }
  void Update()
  {
    transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
  }
}
