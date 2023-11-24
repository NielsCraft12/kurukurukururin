using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownSpinning : MonoBehaviour
{

     
    public player players;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            players.spinningSpeed = 1;

        }
    }
}
