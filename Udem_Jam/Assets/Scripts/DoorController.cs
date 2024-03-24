using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool killed;
    void Start()
    {
        killed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openDoor(){
        this.killed = true;
        this.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().color = Color.blue;
    }
}
