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
    private InputAction scroll;
    [Header("Properties")]
    public static int ph;
    public float scrollDirection;
    public float moveSpeed;
    private float aimAngle;
    [Header("Vectors")]
    private Vector2 moveDirection;
    private Vector2 mousePosition;
    

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        move = playerControls.Player.Move;
        move.Enable();
        fire = playerControls.Player.Fire;
        fire.Enable();
        scroll = playerControls.Player.Scroll;
        scroll.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
        scroll.Disable();
    }

    void Update()
    {
        ProcessInputs();
        weapon.ph = ph;
    }

    void FixedUpdate()
    {
        Move();
        Look();
        Changeph();
    }

    void ProcessInputs() {
        if(fire.IsPressed())
        {
            weapon.Fire();
        }
        moveDirection = move.ReadValue<Vector2>();
        mousePosition = SceneCamera.ScreenToWorldPoint(Input.mousePosition);
        weaponParent.PointerPosition = mousePosition;
        scrollDirection = scroll.ReadValue<float>();
        }

    void Move() {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Look() { 
        Vector2 aimDirection = mousePosition - rb.position;
        aimAngle = (Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f) + 270;
        rb.rotation = (aimAngle >= 270 || aimAngle <= 90) ? 180 : 0;
    }

    void Changeph() {
        if (scrollDirection > 0) {
            ph += (ph != 14) ? 1 : 0;
        }
        if (scrollDirection < 0)
        {
            ph -= (ph != 0) ? 1 : 0;
        }
    }
}
