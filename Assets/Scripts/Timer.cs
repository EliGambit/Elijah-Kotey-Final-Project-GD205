
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int timeleft;// declared a number with a name 
    public Text Countdown;
    void Start()
    {
        StartCoroutine("LoseTime");// makes sure that the timer called "LoseTime" happens in at least one frame
        timeleft = 60;// the value of the int is equal to
   
    }

   void OnTriggerEnter(Collider other)//Void: an object enters the trigger space of another object.This will be the signal for them to collide
    {
       if(other.gameObject.CompareTag("Pick Up"))// if object collides with another object with the tag "Pick Up'
        {
            other.gameObject.SetActive(false);//turn off the object in the game
            if (!GameObject.FindGameObjectWithTag("Pick Up")) {// if the game searches for objects with the tag "Pick Up" and finds nothing

                FindObjectOfType<CustomTeleporter>().enabled = true;//Enable the "Custom Teleporter" script to be active
            } 
        }
    }

void Update()
    {
        Countdown.text = ("Countdown Until Capture:" + timeleft);// Uses the text and the int created in the game
       if (timeleft <= 0)//When the int reaches zero
        {
            FindObjectOfType<Manage>().EndGame();//call the function from the "Manage" script to end the game
        }
      

    }
    IEnumerator LoseTime()// Creates a timer function
    {
        while (true)// While the timer is still being called per frame
        {
            yield return new WaitForSeconds(1);// change seconds per frame 
            timeleft--;//decrease the int by the senconds declared per frame
        }


    }
}






