using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveHorizontal : MonoBehaviour
{
    public float speed;
    public float distance;
    private  Vector2 originalPosition;
    public int direction = 1;
    public PauseMenu pauseobj;
    public PlayerController playerobj;
    private Vector2 newpositionx;
    

    // Start is called before the first frame update
    void Start()
    {

        originalPosition = transform.position;

        Debug.Log("Initial Position: " + originalPosition);

    }

    // Update is called once per frame
    void Update()
    {


        

        if (playerobj.isCompleted!=true)
        {
            MoveH();
            
        }
       
        


    }
    void MoveH()
    {
       
        if (pauseobj.isPaused == false)
        {

            //PingPong is used to oscillate the object and it does not require to write the reverse logic
            //Time.time is used to get smooth animation and is multiplied by speed to control the speed
            float newposition = Mathf.PingPong(speed * Time.time, distance);
            //for changing direction
            newposition *= direction;
            newpositionx = new Vector2(newposition, originalPosition.y);
            //Changin x for horizontal movement
            transform.position = newpositionx;
            
        }
    }

   


}
