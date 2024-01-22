using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    public float speed;
    public float distance;
    private Vector2 originalposition;
    public int direction = 1;
    public PauseMenu pauseobj;
    // Start is called before the first frame update
    void Start()
    {
        //pauseobj = GetComponent<PauseMenu>();
        //Start position of the object
        originalposition = transform.position;
        
    }
     
    // Update is called once per frame
    void Update()
    {
           

       

            MoveH();
     
        

       
        
    }
    void MoveH()
    {       
        //PingPong is used to oscillate the object and it does not require to write the reverse logic
        //Time.time is used to get smooth animation and is multiplied by speed to control the speed
        float newposition = Mathf.PingPong(speed * Time.time, distance);
        //for changing direction
        newposition *= direction;
        if (pauseobj.isPaused != true)
        {
            
            //Changin x for horizontal movement
            transform.position = new Vector2(originalposition.x + newposition, originalposition.y);
        }
        
    }
}
