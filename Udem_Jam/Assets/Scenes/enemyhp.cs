using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhp : MonoBehaviour
{
    private int randomNumber;

    void Start()
    {
        int randomNumber = UnityEngine.Random.Range(0, 15);
        int buffer = 0;
        float attackRange = 2f; 
        int damageAmount = 1;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        while (randomNumber != 7)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= attackRange)
            {
                Debug.Log("Player damaged by " + damageAmount + " HP.");
            }
            switch (randomNumber)
            {
                case 0:
                    if(buffer == 0)
                    {
                        randomNumber++;
                    }
                    break;
                case 1:
                    if (buffer == 0)
                    {
                        randomNumber++;
                    }
                    break;
                case 3:
                    if (buffer == 0)
                    {
                        randomNumber++;
                    }
                    break;
                case 4:
                    if (buffer == 0)
                    {
                        randomNumber++;
                    }
                    break;
                case 5:
                    if (buffer == 0)
                    {
                        randomNumber++;
                    }
                    break;
                case 6:
                    if (buffer == 0)
                    {
                        randomNumber++;
                    }
                    break;
                case 7:
                    break;
                case 8:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                case 9:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                case 10:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                case 11:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                case 12:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                case 13:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                case 14:
                    if (buffer == 0)
                    {
                        randomNumber--;
                    }
                    break;
                default:
                    break;
            }
        }

        if(randomNumber == 7)
        {
            Destroy(gameObject);
        }

    }
}

