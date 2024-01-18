using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxis("Horizontal")>0)//d
        {
            rigidbody2d.velocity = new Vector2(speed , 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)//a
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)//w
        {
            rigidbody2d.velocity = new Vector2(0f,speed);
        }
        else if (Input.GetAxis("Vertical") < 0)//s
        {
            rigidbody2d.velocity = new Vector2(0f,-speed);
        }
        else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            rigidbody2d.velocity = new Vector2(0f,0f);      //stop
        }
         if (Input.GetKey(KeyCode.Space))
        {
            
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "Door")
        {
            UnityEngine.Debug.Log("Level Completed!!!");
        }
        }

}

