using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool isDeathMenu;
    public GameObject DeathMenu;
    public static event Action OnPlayerDamaged;

    public int health, maxHealth;

    public float speed = 3;

    public Weapon weapon;
    public Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 mousePosition;
    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        moveDirection = new Vector2(h, v).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = moveDirection * speed;

        Vector2 aimDirection = mousePosition - rb.position;
        float aimangle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimangle;
    }
    public void Hit(int damage)
    {
        health -= damage;
        OnPlayerDamaged?.Invoke();

        if (health <= 0)
        {
            Time.timeScale = 0.2f;
            StartCoroutine(OpenMenu());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Hit(collision.gameObject.GetComponent<EnemyDamage>().TotalDamage());
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Madriguera"))
        {
            health = maxHealth;
        }
    }
    IEnumerator OpenMenu()
    {
        yield return new WaitForSecondsRealtime(1);
        isDeathMenu = true;
        if (isDeathMenu == true)
        {
            DeathMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
}
