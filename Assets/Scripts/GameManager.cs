using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private SFXManager sfxManager;
    public int vidas = 3;
    public int puntos = 0;
    private int Star;
    public Text ScoreText;
    int ScoreNumber;
    
    
    
    
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

        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }

    public void Restavidas()
    {
        vidas--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DeathStar(GameObject star)
    {
        sfxManager.StarSound();
        ScoreNumber += 1;
        ScoreText.text = "" + ScoreNumber;
    }
}
