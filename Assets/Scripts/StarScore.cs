using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarScore : MonoBehaviour
{
    public Text ScoreText;
    int ScoreNumber;
    
    // Start is called before the first frame update
    void Start()
    {
       ScoreNumber = 0;
       ScoreText.text = " " + ScoreNumber;
    }

    void update()
    {
        if (ScoreNumber == 17)
        {
            SceneManager.LoadScene("Victoria");
        }
    }

    private void OnTriggerEnter2D(Collider2D Star)
    {
        if(Star.tag == "Star")
        {
            ScoreNumber += 1;
            Destroy(Star.gameObject);
            ScoreText.text = " " + ScoreNumber;
            
        }
    }
}
