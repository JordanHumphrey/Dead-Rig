using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour {

    public  Transform[] spawnLocation;
    public  GameObject[] powerCube;
    public  GameObject[] clone;

    public  Text countText;
    public  Text loseText;
    static public int count = 0;

    
    public  float timeDelay = 5;

    public  float spawnTime = 5;
    

     void Start()
    {
        
        SetCountText();
        loseText.text = "";
        InvokeRepeating("spawnPowerCube", 1.0f, timeDelay);                    
    }
    

     void spawnPowerCube()
    {
        count += 1;
        SetCountText();
        int spawnPoint = Random.Range(0,8);
        int ranCube = Random.Range(0, 3);
        clone[ranCube] = Instantiate(powerCube[ranCube], spawnLocation[spawnPoint].transform.position, Quaternion.Euler(0,0,0)) as GameObject;       
    }

     private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "debris")
        {
            Destroy(collision.gameObject);
            count -= 1;
            SetCountText();

        }

    }

      void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 10)
        {
            loseText.text = " YOU LOOSE!";
        }
    }


	
}
