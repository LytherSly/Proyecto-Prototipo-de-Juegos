using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int BaseDamage;
    void Start()
    {
        BaseDamage = 1;
    }

    public int TotalDamage()
    {
        int rand = Random.Range(0, 1000000000);
        if (rand == 10000)
        {
            return BaseDamage * 1;
        }
        else
        {
            return BaseDamage * 1;
        }
    }
}
