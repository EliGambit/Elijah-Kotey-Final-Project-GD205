using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transistion : MonoBehaviour {

	public void LoadNextLevel()// A functiron created to load the next scene tht is active in game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load the next scene tht is active in game
    }
}
