using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = player.position - transform.position;
            direction.Normalize();

            rb.velocity = direction * moveSpeed;
        }
    }
}
