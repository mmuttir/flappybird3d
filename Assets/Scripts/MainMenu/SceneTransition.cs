using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Text gameScore;
    public void GamePlay()
    {
        SceneManager.LoadScene("Game");
        SpawnHurdles.gameOver = false;
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public static void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }
}
