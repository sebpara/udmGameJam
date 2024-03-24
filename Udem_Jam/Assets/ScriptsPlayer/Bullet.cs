using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /*
    [Header("Objects")]

    [Header("Properties")]

    [Header("Vectors")]

    */
    [Header("Objects")]
    public Rigidbody2D rb;
    [Header("Properties")]
    public int ph;
    public float bulletDuration;
    private float currentTime;
    //[Header("Vectors")]
    
    void Start() {
        currentTime = bulletDuration;
    }

    void Update() {
        Destroy();
    }

    public void Destroy() {
        currentTime -= Time.deltaTime;
        if (currentTime < 0) { 
            Destroy(gameObject);
        }
    }
}
