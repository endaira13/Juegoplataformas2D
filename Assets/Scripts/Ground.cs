using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public static bool isGrounded;
    public Transform groundSensor;
    public LayerMask ground;
    public float groundCheckRadius;
    private Animator anim;
    private Vector3 playerVelocity;
    public float jumpForce = 10f;
    private Rigidbody2D rb; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundSensor.position, groundCheckRadius, ground);
        
        if(isGrounded && playerVelocity.x < 0)
       {
         playerVelocity.x = 0;
         anim.SetBool("Saltar", false);
       }

       if(Input.GetButton("Jump") && isGrounded)
       {
          rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
          anim.SetBool("Saltar", true);
       }
       
    }
}
