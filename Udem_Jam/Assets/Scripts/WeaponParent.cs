using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{
    public Vector2 PointerPosition { get; set; }
    public Vector2 direction;
    public GameObject firepoint;
    public Weapon weapon;

    private void Update()
    {
        direction = (PointerPosition - (Vector2)transform.position).normalized;
        transform.right = direction;
        /*Vector2 scale = transform.localScale;
        scale.y = direction.x < 0 ? -1 : 1;
        Vector2 scale2 = firepoint.transform.localScale;
        scale2.y = direction.x < 0 ? -1 : 1;
        transform.localScale = scale;
        firepoint.transform.localScale = scale2;*/
    }
}
