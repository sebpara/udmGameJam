using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2movement : MonoBehaviour
{

    public Transform player;
    public float circleRadius = 2f;
    public float moveSpeed = 2f;

    private Vector2 circleCenter;

    void Start()
    {
        if (player != null)
        {
            circleCenter = player.position;
        }
    }

    void Update()
    {
        if (player != null)
        {
            circleCenter = player.position;

            Vector2 offset = new Vector2(Mathf.Cos(Time.time * moveSpeed), Mathf.Sin(Time.time * moveSpeed)) * circleRadius;
            Vector2 targetPosition = circleCenter + offset;

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
