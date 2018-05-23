using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour {

   public void Quit()//Created a function to quit the game
    {
        Debug.Log("Quit");// Show the text in the console
        Application.Quit();//A function to exit the application
    }
}
