using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    // Start is called before the first frame update
    bool started;
    public GameObject door;
    void Start()
    {
        started = false;
        //spawn or activate enemies
        started = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(!enemyCheck() && started){
            door.GetComponent<BoxCollider2D>().enabled = false;

        }
    }

    bool enemyCheck(){
        for(int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            if(this.gameObject.transform.GetChild(i).tag=="Enemy"){
                return true;
            }
        }
        Debug.Log("opening door");
        door.GetComponent<SpriteRenderer>().color = Color.blue;
        return false;
    }
}
