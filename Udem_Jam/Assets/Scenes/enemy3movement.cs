using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3movement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float blinkSpeed = 10f;
    public float stopDuration = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(BlinkFollow());
    }

    IEnumerator BlinkFollow()
    {
        while (true)
        {
            if (player != null)
            {
                Vector2 direction = player.position - transform.position;
                direction.Normalize();
                rb.velocity = direction * blinkSpeed;

                yield return new WaitForSeconds(stopDuration);

                rb.velocity = Vector2.zero;

                yield return null; 
            }
            yield return null;
        }
    }
}
