using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera SceneCamera;
    public float moveSpeed;
    public Rigidbody2D rb;
    Vector3[] levels;
    int index;

    private Vector2 moveDirection;
    private Vector2 mousePosition;

    void Start(){
        index = 0;
        levels = new Vector3[2];
        levels[0] = new Vector3(108.16f, 0.71f, 0f);
        levels[1] = new Vector3(205.5f, 0.71f, 0f);
    }
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs() {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = SceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void Move() {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }

    public void LevelUp(){
        if(index==3){
            //game over screen
        }
        this.GetComponent<Transform>().position = levels[index];
        index++;
    }
}
