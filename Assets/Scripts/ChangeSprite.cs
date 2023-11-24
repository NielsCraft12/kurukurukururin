using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class ChangeSprite : MonoBehaviour

{

    public player players;
    public SpriteRenderer spriteRenderer;
    public Sprite healing;
    public Sprite normal;
    public Sprite srinkedStick;
    public Sprite healingSmall;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (players.isHealing == true && players.srinked == false)
        {
            GetComponent<SpriteRenderer>().sprite = healing;
        } else if (players.isHealing == false && players.srinked == false)
        {
            GetComponent<SpriteRenderer>().sprite = normal;
        }else if (players.srinked == true && players.isHealing == false)
        {
            GetComponent<SpriteRenderer>().sprite = srinkedStick;
           // GetComponent<BoxCollider2D>().size = new Vector2(0.27f, 1.47f);
        }
        else if (players.srinked == false && players.isHealing == false)
        {
            GetComponent<SpriteRenderer>().sprite = normal;
            //GetComponent<BoxCollider2D>().size = new Vector2(0.32f, 2.64f);
        }
        else if (players.srinked == true && players.isHealing == true)
        {
            GetComponent<SpriteRenderer>().sprite = healingSmall;
            //GetComponent<BoxCollider2D>().size = new Vector2(0.27f, 1.47f);
        }
        else if (players.srinked == false && players.isHealing == false)
        {
            GetComponent<SpriteRenderer>().sprite = normal;
           // GetComponent<BoxCollider2D>().size = new Vector2(0.32f, 2.64f);
        }
    }
}
