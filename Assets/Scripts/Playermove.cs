using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed = 5;
    private float horizontal;
    private Transform playerTransform;

    private Rigidbody2D rb; 

    // Start is called before the first frame update

    private void Awake() 
    {
      rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
       playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxisRaw("Horizontal");

       //playerTransform.position += new Vector3(horizontal * speed * Time.deltaTime,0,0);

       //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);

    }

    private void FixedUpdate() 
    {
      rb.velocity = new Vector2(horizontal * speed ,0);
    }
}
