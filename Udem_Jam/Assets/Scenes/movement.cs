using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Rigidbody2D rb;

    Vector2 movements;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movements.x = Input.GetAxisRaw("Horizontal");
        movements.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movements * moveSpeed * Time.fixedDeltaTime);
    }
}
