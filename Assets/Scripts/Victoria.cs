using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
   public GameObject mainButtons;
   public GameObject cartel;



   public void OpenOpcions()
    {
        mainButtons.SetActive(false);
        cartel.SetActive(true);
    }
    

   public void SceneMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
