using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Manage : MonoBehaviour {
    bool gamehasEnded = false; //Declare a means to end the game
    public float restartDelay = 1f;// The amount of time before the game or level restarts
    public GameObject finishLevelUI;// The game object "Level Complete" UI to call the panel and text when needed
    public void CompleteLevel()//Created a function to know when the goal has been reached
    {
        finishLevelUI.SetActive(true);//The "Level Complete" panel and text is turned off in game. Setting it to "true" will turn it back on
    }
    public void EndGame()//Created a function to end the game when the player has failed or lossed.
    {
        if (gamehasEnded == false)//If the bool for the function is turned off
        {
            gamehasEnded = true;//Turn function on
            Debug.Log("Game Over");//say "Game Over" in the console
            //Invoke("Restart", restartDelay); //schedule the restart function and restart delay to activate at a certain time
            Restart();// call this function in the "EndGame" function
        }

      
    }
    void Restart()//Created this function to reload the the desired scene after losing the game via "EndGame" function
    {
        SceneManager.LoadScene("Lose");//Load the specific scene called "Lose"
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);// Loads the scene that is "active" or first on your screen.
    }
}
