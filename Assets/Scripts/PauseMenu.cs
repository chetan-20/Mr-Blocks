using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausescreen;
    internal bool isPaused = false;


    public void TogglePause(bool checkcomplete, Rigidbody2D x)//Handle Pause Event
    {
        if (Input.GetKeyDown(KeyCode.Escape) && checkcomplete == false)//Pause Screen Logic
        {
            isPaused = !isPaused;
            pausescreen.SetActive(isPaused);
        }
        if (isPaused == true)
        {
            x.velocity = new Vector2(0f, 0f);
        }
    }
}
