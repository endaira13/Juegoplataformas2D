using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{   
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       isGrounded = false; 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       isGrounded = false; 
    }
    
    

  
}