using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public Text MyText;
    public player players;


    // Use this for initialization
    void Start()
    {

        MyText.text = "";

    }


    // Update is called once per frame
    void Update()
    {

        MyText.text = "lives:"+ players.lives;
    }
}
