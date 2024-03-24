using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [Header("Objects")]
    public GameObject bullet;
    public Transform firePoint;
    [Header("Properties")]
    public float fireForce;
    public float firingSpeed;
    private float currentTime;
    public int ph;
    //[Header("Vectors")]

    void Update() {
        currentTime -= Time.deltaTime;
    }

    public void Fire() {
        if (currentTime <= 0) { 
            GameObject projectile = Instantiate(bullet, firePoint.position, firePoint.rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            projectile.GetComponent<Bullet>().ph = ph;
            currentTime = firingSpeed;
        }
    }

}
