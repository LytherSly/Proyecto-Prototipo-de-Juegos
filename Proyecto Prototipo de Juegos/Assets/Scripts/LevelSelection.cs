using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public bool canEnterLevel1;
    public bool canEnterLevel2;


    private void Update()
    {
        if (canEnterLevel1 == true && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Nivel 1");
        }
        if (canEnterLevel2 == true && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Nivel 2");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Level 1"))
        {
            canEnterLevel1 = true;
        }
        if (other.CompareTag("Level 2"))
        {
            canEnterLevel2 = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        canEnterLevel1 = false;
        canEnterLevel2 = false;
    }
}
