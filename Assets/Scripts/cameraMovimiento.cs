using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovimiento : MonoBehaviour
{
    [SerializeField]private float duration;
    [SerializeField]private float magnitude;
    void Start()
    {
       //Llamarfuncion
       // Shake();
        //llamar corutina
        //SartCoroutine(Shake());
    }
    
    
    
    IEnumerator Shake()
    {
        //Espera x segundos
      //yield return new waitForSeconds(1f);  

      Vector3 originalPos = transform.position;
      float elapsed = 0f;

      /*while(elapsed < duration)
      {
        float x = Random.Range(-1f, 1f) * magnitude;
        float y = Random.Range(-1f, 1f) * magnitude;

        transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
        elapsed += Time.deltaTime;
        yield return 0;
      }*/

      /*for(float elapsed = 0; < duration, Time.deltaTime++)
      {
        float x = Random.Range(-1f, 1f) * magnitude;
        float y = Random.Range(-1f, 1f) * magnitude;

        transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
        yield return 0;
      }*/
      
      do 
      {
        float x = Random.Range(-1f, 1f) * magnitude;
        float y = Random.Range(-1f, 1f) * magnitude;

        transform.position = new Vector3(x + originalPos.x, y + originalPos.y, transform.position.z);
        elapsed += Time.deltaTime;
        yield return 0;


      }while(elapsed < duration);

      /*GameObject[] vidas;

      foreach(GameObject vida in vidas)
      {
        vida.SetActive(false);
      }*/
    }
}
