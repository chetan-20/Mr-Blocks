using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    public GameObject pausescreen;
    public GameObject Levelcompleted;
    private bool isPaused=false;
    private bool isCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") > 0)//d
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);

        }
        else if (Input.GetAxis("Horizontal") < 0)//a
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }

        else if (Input.GetAxis("Vertical") > 0)//w
        {
            rigidbody2d.velocity = new Vector2(0f, speed);

        }
        else if (Input.GetAxis("Vertical") < 0)//s
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);

        }
        else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            rigidbody2d.velocity = Vector2.zero;      //stop
        }
         if (Input.GetKey(KeyCode.Space))//If Pressed space
        {
             rigidbody2d.velocity = new Vector2(0f, 0f);
        }
         TogglePause();
         if (isCompleted == true)
            {
                rigidbody2d.velocity = new Vector2(0f, 0f);
            }
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "Door")
        {
            isCompleted = true;
            Levelcompleted.SetActive(true);
            
        }
        }
    private void TogglePause()//Handle Pause Event
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isCompleted==false)//Pause Screen Logic
        {
            isPaused = !isPaused;
            pausescreen.SetActive(isPaused);
        }
        if (isPaused == true)
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
    }

}

