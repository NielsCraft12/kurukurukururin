using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class LevelEndTrigger : MonoBehaviour
{
    [SerializeField] private player Player;
    private Collider2D m_Collider;
    public Vector3 m_Center;
    [SerializeField] private Transform endpad;



    private void Update()
    {

        m_Center = new Vector3(endpad.position.x, endpad.position.y,0);

        //Debug.Log(m_Center);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Player.end = true;
             //SceneManager.LoadScene("Level2");
        }
    }


}
