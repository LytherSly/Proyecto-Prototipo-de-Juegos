using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(BulletDelete());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    IEnumerator BulletDelete()
    {
        yield return new WaitForSecondsRealtime(3);
        Destroy(gameObject);
    }
}
