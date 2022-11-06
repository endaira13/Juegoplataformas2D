using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private SFXManager sfxManager;
    private int vidas = 3;
    public int puntos = 0;
    private int Star;
    public Text ScoreText;
    int ScoreNumber;
    public GameObject[] hearts;
    

    
    

    
    
    void Awake()
    {
      
        //Si ya hay una instancia y no soy yo me destruyo
       if(Instance != null && Instance != this) 
       {
        Destroy(this);
       }
       else
       {
        Instance = this;
       }

       DontDestroyOnLoad(this);

       
    }
    void Start()
    {
        vidas = hearts.Length;
    }

    public void Restavidas()
    {
        if(vidas < 1)
        {
          Destroy(hearts[0].gameObject); 
          Invoke("loadMainMenu", 1);
        }
        if(vidas < 2)
        {
          Destroy(hearts[1].gameObject); 
          
        }
        if (vidas < 3)
        {
          Destroy(hearts[2].gameObject);
           
        }

        vidas --;
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void DeathStar(GameObject star)
    {
        SFXManager.Instance.StarSound();
        ScoreNumber += 1;
        ScoreText.text = "" + ScoreNumber;
        Invoke("loadMenu", 1);
    }

    public void loadMenu()
    {
       if (ScoreNumber == 17)
        {
            SceneManager.LoadScene("Victoria");
            SFXManager.Instance.VictoriaSound();
        }
    }

    public void loadMainMenu()
    {
       SceneManager.LoadScene("GameOver");
       SFXManager.Instance.MuerteSound(); 
    }

    public void DeathBomba(GameObject bomba)
    {
        SFXManager.Instance.BombaSound();
        
    }


}
