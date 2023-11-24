using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springTrigger : MonoBehaviour
{
    public player players;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if (players.isReversed == false)
            {
                players.isReversed = true;
            }else if (players.isReversed == true)
            {
                players.isReversed = false;
            }
        }
    }
}
