using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombas : MonoBehaviour
{
    public GameObject efecto;
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            GameObject clonEx = Instantiate(efecto, transform.position, Quaternion.identity) as GameObject;
            Destroy(clonEx, 0.5f);
            Destroy(gameObject);
             
        }
    }
}
