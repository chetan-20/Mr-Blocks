using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    public float speed;
    public float distance;
    private Vector2 originalposition;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        originalposition = transform.position;
    }
     
    // Update is called once per frame
    void Update()
    {
        float newposition = Mathf.PingPong(speed*Time.time,distance);
        
        transform.position = new Vector2(originalposition.x+newposition,originalposition.y);
        
    }
}
