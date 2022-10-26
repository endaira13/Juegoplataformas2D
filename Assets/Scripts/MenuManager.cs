using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject title;
    public GameObject mainButtons;
    public GameObject opcionsMenu;


    public void OpenOpcions()
    {
        title.SetActive(false);
        mainButtons.SetActive(false);
        opcionsMenu.SetActive(true);
    }

    public void ScenePlatfors()
    {
        SceneManager.LoadScene("Platforms");
    }
}
