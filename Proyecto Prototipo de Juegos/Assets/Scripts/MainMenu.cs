using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameObject Settings1, Settings2, Settings3, SFX, Music, Master, Text1, Text2, Text3, TextOpciones, MasterText, SFXText, MusicText, Boton1,Boton2,Boton3, BotonRegreso;
    

    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Selection Screen");
    }

    public void Settings()
    {
        Settings1.SetActive(true);
        Settings2.SetActive(true);
        Settings3.SetActive(true);
        SFX.SetActive(true);
        Music.SetActive(true);
        Master.SetActive(true);
        SFXText.SetActive(true);
        MusicText.SetActive(true);
        MasterText.SetActive(true);
        TextOpciones.SetActive(true);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Boton1.SetActive(false);
        Boton2.SetActive(false);
        Boton3.SetActive(false);
        BotonRegreso.SetActive(true);
    }

    public void BackButton()
    {
        Text1.SetActive(true);
        Text2.SetActive(true);
        Text3.SetActive(true);
        TextOpciones.SetActive(false);
        Settings1.SetActive(false);
        Settings2.SetActive(false);
        Settings3.SetActive(false);
        SFX.SetActive(false);
        Music.SetActive(false);
        Master.SetActive(false);
        SFXText.SetActive(false);
        MusicText.SetActive(false);
        MasterText.SetActive(false);
        Boton1.SetActive(true);
        Boton2.SetActive(true);
        Boton3.SetActive(true);
        BotonRegreso.SetActive(false);
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
