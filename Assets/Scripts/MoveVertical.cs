using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVertical : MonoBehaviour
{
    
    public float speed;
    public float distance;
    private Vector2 originalposition;



    // Start is called before the first frame update
    void Start()
    {
        //Start position of the object
        originalposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //PingPong is used to oscillate the object and it does not require to write the reverse logic
        //Time.time is used to get smooth animation and is multiplied by speed to control the speed
        float newposition = Mathf.PingPong(speed * Time.time, distance);
        //Changin y for vertical movement
        transform.position = new Vector2(originalposition.x, originalposition.y+newposition);

    }
}

