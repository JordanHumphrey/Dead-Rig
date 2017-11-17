using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {
    public Text countText;
    public Text loseText;
    public int count;

	// Use this for initialization
	void Start () {
        count = 0;
        SetCountText();
        loseText.text = " ";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
        {
            loseText.text = " you loose";
        }
    }
}
