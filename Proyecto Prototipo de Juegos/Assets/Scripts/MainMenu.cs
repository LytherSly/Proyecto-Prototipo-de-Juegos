using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Selection Screen");
    }
    public void Retry1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel 1");
    }

    public void Retry2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel 2");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
