using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRepaso : MonoBehaviour
{
    //Movimiento
    private Rigidbody2D rBody;
    private float horizontal;
    [SerializeField]private float speed = 3;
    private Animator anim;
    
    //salto
    [SerializeField]private float jumpForce = 10;
    [SerializeField]Transform groundSensor;
    [SerializeField]float sensorRadius;
    [SerializeField]LayerMask sensorLayer;
    [SerializeField]bool isGrounded;

    // Start is called before the first frame update
     void Awake()
    {
        //Movimiento
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        horizontal = Input.GetAxis("Horizontal");

        if(horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("isRuning", true);
        }

        else if(horizontal > 0)
        {
           transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("isRuning", true); 
        }

        else if(horizontal == 0)
        {
            anim.SetBool("isRuning", false);
        }

        //Salto
        isGrounded = Physics2D.OverlapCircle(groundSensor.position, sensorRadius, sensorLayer);
        
        if( isGrounded && Input.GetButtonDown("Jump"))
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }
    }

    void FixedUpdate() 
    {
        //Movimiento
        rBody.velocity = new Vector2(horizontal * speed,rBody.velocity.y);
    }

    //Salto
    void OnCollisionEnter2D(Collision2D coll) 
    {
        if(coll.gameObject.layer == 6)
        {
            anim.SetBool("isJumping", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.gameObject.tag == "Star") 
       {
         gamemanager1.Instance.LoadLevel(4);
       }

       else if (other.gameObject.tag == "Coin")
       {
         gamemanager1.Instance.AddCoin(other.gameObject);
       }
    }
}
