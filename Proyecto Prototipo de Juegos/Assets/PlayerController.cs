using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool isDeathMenu;
    public GameObject DeathMenu;

    public int MaxHealth;
    public int CurrentHealth;
    public Slider HealthBar;

    public Weapon weapon;
    public Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 mousePosition;
    private void Start()
    {
        CurrentHealth = MaxHealth;
        HealthBar.value = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        moveDirection = new Vector2(h, v).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        HealthBar.value = CurrentHealth;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * 5, moveDirection.y * 5);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimangle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimangle;
    }
    public void Hit(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth < 1)
        {
            Time.timeScale = 0.2f;
            StartCoroutine(OpenMenu());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Hit(other.GetComponent<EnemyDamage>().TotalDamage());
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
