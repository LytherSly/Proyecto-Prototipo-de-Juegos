using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        print("Start Game");
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Selection Screen");
    }

    public void Settings()
    {
        Debug.Log("Settings");
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}