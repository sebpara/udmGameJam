using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Objects")]
    public Camera SceneCamera;
    public Weapon weapon;
    public WeaponParent weaponParent;
    public Rigidbody2D rb;
    [Header("Input")]
    public PlayerControls playerControls;
    private InputAction move;
    private InputAction fire;
    
    [Header("Properties")]
    public int ph;
    public float moveSpeed;
    [Header("Vectors")]
    private Vector2 moveDirection;
    private Vector2 mousePosition;
    public float aimAngle;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        move = playerControls.Player.Move;
        move.Enable();
        fire = playerControls.Player.Fire;
        fire.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
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
        if(fire.IsPressed())
        {
            weapon.Fire();
        }
        moveDirection = move.ReadValue<Vector2>();
        mousePosition = SceneCamera.ScreenToWorldPoint(Input.mousePosition);
        weaponParent.PointerPosition = mousePosition;
        }

    void Move() {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        Vector2 aimDirection = mousePosition - rb.position;
        aimAngle = (Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f) + 270;
        rb.rotation = (aimAngle >= 270 || aimAngle <= 90) ? 180 : 0;
    }

    void Changeph() { 
    
    }
}
