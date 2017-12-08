using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimplePauseMenu : MonoBehaviour
{
  public GameObject PauseMenu;
  void Start ()
  {
  }

  void Update ()
  {
    //handles pause menu
    if (Input.GetKeyDown("p")||Input.GetKeyDown(KeyCode.Escape)) //unlocks mouse after pressing escape key
    {
      if (Time.timeScale == 1/*PauseMenu.gameObject.activeInHierarchy == false*/)
      {
        //if pause menu is active
        //PauseMenu.SetActive(true);
        Time.timeScale = 0;
        print("PAUSED");
      }
      else
      {
        //if pause menu is not active
        //PauseMenu.SetActive(false);
        Time.timeScale = 1;
        print("UNPAUSED");
      }
    }
  }
}
