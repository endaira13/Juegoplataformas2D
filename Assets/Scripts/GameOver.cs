using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public GameObject mainButtonsRestart;
   public GameObject mainButtonsMenu;
   public GameObject menu;



   public void OpenOpcions()
    {
        mainButtonsRestart.SetActive(false);
        mainButtonsMenu.SetActive(false);
        menu.SetActive(true);
    }
    

   public void ScenePlataforms()
    {
        SceneManager.LoadScene("Platforms");
    }
    public void SceneMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
