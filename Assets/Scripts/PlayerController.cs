using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class PlayerController : MonoBehaviour
{
    
    private Restart restart;
    public Rigidbody2D rigidbody2d;
    public float speed;
    private PauseMenu pause;//PauseMenu object
    public GameObject Levelcompleted;
    public GameObject LevelLost;
    
    private bool isCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        pause = GetComponent<PauseMenu>();//necessary to initialise this before starting other scripts
        restart = GetComponent<Restart>();
        
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
            rigidbody2d.velocity = Vector2.zero;      //stop
        }
        if (isCompleted == true)
        {
            rigidbody2d.velocity = Vector2.zero;
        }
        pause.TogglePause(isCompleted,rigidbody2d);
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "Door")
        {
            isCompleted = true;
            Levelcompleted.SetActive(true);
            
        }
        if (other.tag == "Enemy")
        {
            isCompleted = true;
            LevelLost.SetActive(true);

        }
    }
   
    public bool getIsComplete()
    {
        return isCompleted;
    }

}

