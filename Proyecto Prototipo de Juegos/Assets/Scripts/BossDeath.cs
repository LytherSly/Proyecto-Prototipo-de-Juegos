using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeath : MonoBehaviour
{
    public GameObject WinMenu;
    public EnemyHealth BossHealth;

    private void Update()
    {
        if (BossHealth.CurrentEnemyHealth <= 0)
        {
            StartCoroutine(Ganaste());
        }
    }
    IEnumerator Ganaste()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 0;
        WinMenu.SetActive(true);
    }
}
