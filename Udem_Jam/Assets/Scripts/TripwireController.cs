using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripwireController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enterDoor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="Player"){
            Debug.Log("COLLISION with PLAYER");
            enterDoor.GetComponent<SpriteRenderer>().enabled = true;
            enterDoor.GetComponent<BoxCollider2D>().enabled = true;
            //enterDoor.GetComponent<DoorController>().enabled = true;
        }
        
    }
}
