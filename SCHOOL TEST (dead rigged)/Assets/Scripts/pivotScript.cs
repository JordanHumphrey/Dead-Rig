using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivotScript : MonoBehaviour {

    public float gizmoSize = .75f;
    public Color gizmoColor = Color.yellow;



    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
