using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float dashSpeed = 2000000;

    bool dash = true;
    int dashCooldown = 40;
    private bool dashApretado;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dashApretado = true;
        }
    }

    void FixedUpdate()
    {
        if (dashCooldown == 0)
        {
            dash = true;
        }
        else
        {
            dashCooldown--;
        }


        if (dash && dashApretado)
        {
            Vector2 mouseDirection = (Input.mousePosition - new Vector3(Screen.width / 2, Screen.height / 2)).normalized;
            GetComponent<PlayerController>().rb.AddForce(mouseDirection * dashSpeed * Time.fixedDeltaTime);
            dash = false;
            dashApretado = false;
            dashCooldown = 40;
        }
    }
}
