using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour {
    public Manage gameManager;
    //Void: an object enters the trigger space of another object.This will be the signal for them to collide
    private void OnTriggerEnter(Collider other)
    {
        //Call a function from the gameManager object.
        //The CompleteLevel function is to call the Level Complete panel when the goal has been reached in the game.
        gameManager.CompleteLevel();
    }
}
