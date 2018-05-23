using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
public void StartGame()//created a function to begin the game
    {
        SceneManager.LoadScene("Final Project");//Load the desired scene named "Final Project"
    }
}
