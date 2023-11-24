using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealPadTrigger : MonoBehaviour
{
    public player players;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            if (players.hardMode == false)
            {
                players.lives = 3;
                players.isHealing = true;
            } else if (players.hardMode == true)
            {
                players.lives = 1;
                players.isHealing = true;
            }
      
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            players.isHealing = false;

        }
    }
}
