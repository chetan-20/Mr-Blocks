
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausescreen;
    internal bool isPaused = false;


    public void TogglePause(bool checkcomplete,Rigidbody2D x)//Handle Pause Event
    {
        if (Input.GetKeyDown(KeyCode.Escape) && checkcomplete == false)//Pause Screen Logic
        {
            isPaused = !isPaused;
            x.velocity = Vector2.zero;
            if (isPaused== true){
                Time.timeScale = 0f;

            }
            else
            {
                Time.timeScale = 1f;
            }
            pausescreen.SetActive(isPaused);
        }
       
    }
}
