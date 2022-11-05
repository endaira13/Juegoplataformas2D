using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI; 

public class Playermove : MonoBehaviour
{
    public float speed = 5f;
    private float horizontal;
    private Transform playerTransform;
    private float jump;
    public float jumpForce = 10f;
    public float gravity = 25f;
   
    public PlayableDirector director;

    private Rigidbody2D rb; 
    private Animator anim;
    private GameManager gameManager;
    
    public Image Corazon;
    public RectTransform PositionPrimerCorazon;
    public Canvas MyCanvas;
    public int Offset;
    public int CantDeCorazones;
    
    

    // Start is called before the first frame update

    private void Awake() 
    {
      rb = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();
      gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    void Start()
    {
      playerTransform = GetComponent<Transform>();
      Transform PosicionCorazon = PositionPrimerCorazon;
        for (int i = 0; i < CantDeCorazones; i ++)
        {
          Image NewCorazon = Instantiate(Corazon,PosicionCorazon.position, Quaternion.identity);
          NewCorazon.transform.parent = MyCanvas.transform;
          PosicionCorazon.position = new Vector2(PosicionCorazon.position.x + Offset, PosicionCorazon.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxisRaw("Horizontal");


       if(horizontal == 0)
       {
          anim.SetBool("Correr", false);
       }
      
       else
       {
          anim.SetBool("Correr", true);
       }

       jump = Input.GetAxisRaw("Jump");
        
       if(jump == 0)
       {
         anim.SetBool("Saltar", false);
       }
       else
       {
         anim.SetBool("Saltar", true);
       }
       
       GameManager.Instance.Restavidas();
       //GameManager.Instance.vidas;
       //Global.nivel = 1;
       //playerTransform.position += new Vector3(horizontal * speed * Time.deltaTime,0,0);

       //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);

    }


    private void FixedUpdate() 
    {
      rb.velocity = new Vector2(horizontal * speed ,0);
      if(rb.velocity.x > 0)
       {
         transform.localScale = new Vector3(1f, 1f, 1f);
       }

       else if(rb.velocity.x < 0)
       {
         transform.localScale = new Vector3(-1f, 1f, 1f);  
       }
      

      if(Input.GetButton("Jump"))
        {
          rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
          anim.SetBool("Saltar", true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.tag == "cinematica")
      {
        director.Play();
      }
      if(other.gameObject.CompareTag("Star"))
      {
        Destroy(other.gameObject);
        gameManager.DeathStar(other.gameObject);
      }
      if(other.gameObject.CompareTag("Bomba"))
      {
        gameManager.DeathBomba(other.gameObject);
        Destroy(MyCanvas.transform.GetChild(CantDeCorazones + 1).gameObject);
        CantDeCorazones -= 1;
      }
        
    }


}
