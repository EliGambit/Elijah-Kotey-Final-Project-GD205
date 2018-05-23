using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Rigidbody rb;// create a slot for the rigied body of a game object
    public float powerAmt;// create  a slot for delcaring a number for the force needed for the player to move
    public float jump;// created a slot for delcaring a number for the force needed for the player to jump
    public bool Ground;// created a bool to know when the player is touching the ground or an object

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))// if the up arrow on the keyboard is pressed 
        {
            rb.AddForce(Vector3.forward * powerAmt);// add force to the rigid body in the forward direction based on the number presented  by the "powerAmt"
        }
        if (Input.GetKey(KeyCode.DownArrow))// if the down arrow on the keyboard is pressed
        {
            rb.AddForce(Vector3.back * powerAmt); // add force to the rigid body in the backward direction based on the number presented  by the "powerAmt"
        }
        if (Input.GetKey(KeyCode.LeftArrow))// if the left arrow on the keyboard is pressed
        {
            rb.AddForce(Vector3.left * powerAmt);// add force to the rigid body in the left direction based on the number presented  by the "powerAmt"
        }
        if (Input.GetKey(KeyCode.RightArrow))// if the right arrow on the keyboard is pressed
        {
            rb.AddForce(Vector3.right * powerAmt);// add force to the rigid body in the right direction based on the number presented  by the "powerAmt"
        }
        if (Input.GetKey(KeyCode.Space)&& Ground)// if the space bar on the keyboard is pressed and the player is colliding with another object(ground, wall, or object)
        {
            rb.AddForce(Vector3.up * jump);// add force to the rigid body in the upward direction based on the number presented  by the "jump"
            Ground = false;// then the ground bool is set to false
        }
        //if (rb.position.y < -1f)
        //{
            //FindObjectOfType<Manage>().EndGame();
        //}
    }
    private void OnCollisionStay(Collision collision)// if the the object stays collding with another object
    {
        Ground = true;// set the ground bool to true 
    }
}