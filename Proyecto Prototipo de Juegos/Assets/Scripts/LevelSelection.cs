using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public bool canEnterLevel;
    private void Update()
    {
        if (canEnterLevel == true && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Nivel 1");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canEnterLevel = true;      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canEnterLevel = false;
    }
}
