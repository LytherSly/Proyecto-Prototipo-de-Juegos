using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int MaxEnemyHealth, CurrentEnemyHealth;

    private void Start()
    {
        CurrentEnemyHealth = MaxEnemyHealth;
    }

    private void Update()
    {
        if (CurrentEnemyHealth <= 0)
        {
            StartCoroutine(EnemyDeath());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            CurrentEnemyHealth--;
        }
    }
    IEnumerator EnemyDeath()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        Destroy(gameObject);
    }
}
