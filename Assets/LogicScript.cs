using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// add ui
using TMPro;

// add scence 
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // score
    public int playerScore;
    // update the score txt ui => reference to it
    public TextMeshProUGUI scoreText; 

    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]

    // add score function
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    // restart game function
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // game over function
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
