using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCollision : MonoBehaviour {
    public Move movement;//declares the "Move" script in this script
    
    void OnCollisionEnter(Collision collsionInfo)//a function for getting information when an object has collided with another
    {
        if(collsionInfo.collider.name == "Win")//if the object collides with another object called "Win"
        {
            movement.enabled = false;// Disable the movemnt from the "Move" script
            FindObjectOfType<Manage>().EndGame();//Call the function from the "Manage" script to end the game
        }
    }
	
}
