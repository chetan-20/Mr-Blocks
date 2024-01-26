
using UnityEngine;
using UnityEngine.EventSystems;




public class PlayerController : MonoBehaviour
{


    public Rigidbody2D rigidbody2d;
    public float speed;
    internal PauseMenu pause;//PauseMenu object
    public GameObject LevelcompletedPanel;
    public GameObject LevelLostPanel;

    internal bool isCompleted = false;
    [SerializeField] private AudioSource movingsound;
    [SerializeField] private AudioSource stopsound;
    [SerializeField] private AudioSource GameLostsound;
    [SerializeField] private AudioSource Gamewonsound;
    
    // Start is called before the first frame update
    void Start()
    {
        pause = GetComponent<PauseMenu>();//necessary to initialise this before starting other scripts
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") > 0)//d
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);
            movingsound.Play();

        }
        else if (Input.GetAxis("Horizontal") < 0)//a
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
            movingsound.Play();
        }

        else if (Input.GetAxis("Vertical") > 0)//w
        {
            rigidbody2d.velocity = new Vector2(0f, speed);
            movingsound.Play();

        }
        else if (Input.GetAxis("Vertical") < 0)//s
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
            movingsound.Play();

        }
        else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            rigidbody2d.velocity = Vector2.zero;
            movingsound.Stop();//stop
        }
         if (Input.GetKeyDown(KeyCode.Space))//If Pressed space
        {
            stopsound.Play();
            rigidbody2d.velocity = Vector2.zero;
           
        }
        if (isCompleted == true)
        {
            rigidbody2d.velocity = Vector2.zero;

            movingsound.Stop();
            stopsound.Stop();
            
        }
        
        pause.TogglePause(isCompleted,rigidbody2d);
    }

    private void OnTriggerEnter2D(Collider2D other)
        { 
        Time.timeScale = 0f;
        if (other.tag == "Door")
        {
            isCompleted = true;
            LevelcompletedPanel.SetActive(true);
            Gamewonsound.Play();
                  
        }
        if (other.tag == "Enemy")
        {
            isCompleted = true;
            LevelLostPanel.SetActive(true);
            GameLostsound.Play();
        }
    }
   

}

