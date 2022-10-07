using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; 

public class Playermove : MonoBehaviour
{
    public float speed = 5;
    private float horizontal;
    private Transform playerTransform;
    private float jump;
    public float jumpForce = 10;
    public bool isGrounded;
    
    
    
    

    public PlayableDirector director;

    private Rigidbody2D rb; 
    private Animator anim;
    

    // Start is called before the first frame update

    private void Awake() 
    {
      rb = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();

    }
    void Start()
    {
       playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxisRaw("Horizontal");


       if(horizontal == 0)
       {
          anim.SetBool("Correr", true);
       }
      
       else
       {
          anim.SetBool("Correr", false);
       }

       if(jump == 0)
       {
         anim.SetBool("Saltar", true);
       }
       else
       {
         anim.SetBool("Saltar", false);
       }
       
      



       //playerTransform.position += new Vector3(horizontal * speed * Time.deltaTime,0,0);

       //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);

    }

    private void FixedUpdate() 
    {
      rb.velocity = new Vector2(horizontal * speed ,0);
      

      if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
      {
        rb.AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
      }

      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.tag == "cinematica")
      {
        director.Play();
      }
      
    }
}
