using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour {

    public float speed = 30;                //sets the speed variable for racket movement. Speed variable is public to enable quick editing in the Ins
    public string axis = "Vertical";

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);   // GetAxisRaw checks the vertical input axis. This returns 1 when using the up arrow, W key or joystick upwards = racket movers up.
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed; // Pressing S, down arrow or down on joystick results in -1 = racket moves down. 
    }                                                                     // If neither are presseed the state returns to 0. 
}



 
 

