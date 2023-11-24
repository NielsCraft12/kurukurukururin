using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SmallDoorScript : MonoBehaviour
{

    public player players;

    [SerializeField] private SpriteRenderer doorSpriteRenderer;
    [SerializeField] private BoxCollider2D doorBoxCollider;

    private void Update()
    {
        if (players.srinked == true)
        {
            doorSpriteRenderer.enabled = false;
            doorBoxCollider.enabled = false;
        } else if (players.srinked == false)
        {
            doorSpriteRenderer.enabled = true;
            doorBoxCollider.enabled = true;
        }
    }

}
