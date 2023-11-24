using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    public int lives;
     float hurttimer;
    [SerializeField] bool godmode;
    [SerializeField] private string nextSceneName;
    public bool isHealing;
    public int spinningSpeed = 0;
    public bool srinked;
    public bool end;
    public LevelEndTrigger endTrigger;
    [SerializeField] private float endTimer = 3f;
    private Vector3 playerPosition;
    [SerializeField] private Transform playerObj;
    public bool isReversed;
    public bool hardMode = false;



    // Start is called before the first frame update
    void Start()
    {
      int hardmodeSave = PlayerPrefs.GetInt("hardmode");

        if (hardmodeSave == 1)
        {
            hardMode = true;
        }

        if (hardMode == true)
        {
            lives = 1;
        } else if (hardMode == false)
        {
            lives = 3;
        }
        m_Rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3(playerObj.position.x,playerObj.position.y,0f);
        

        if (lives == 0 && godmode == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        if(hurttimer > 0)
        {
            hurttimer -= Time.deltaTime;

            if (hurttimer <= 0) 
            {
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                hurttimer = 0;
            }
        }


        if (srinked == false)
        {
            GetComponent<BoxCollider2D>().size = new Vector2(0.32f, 2.64f);
        } else if (srinked == true)
        {
            GetComponent<BoxCollider2D>().size = new Vector2(0.11f, 1.26f);
        }


        if (end)
        {
            transform.position = Vector3.Lerp(playerPosition, endTrigger.m_Center, Time.deltaTime * 2);
            m_Rigidbody.rotation += 5f;
            //endTimer = 3;
                endTimer -= Time.deltaTime;
            this.GetComponent<Collider2D>().enabled = false;

            if (endTimer <= 0)
            {
                endTimer = 3f;
                SceneManager.LoadScene(nextSceneName);
            }
        }
                

    }

    private void FixedUpdate()
    {
        if (spinningSpeed == 0 && isReversed == false)
        {
         m_Rigidbody.rotation += 2f;
        }

        if (spinningSpeed == 2 && isReversed == false)
        {
            m_Rigidbody.rotation += 4f;
        }

        if (spinningSpeed == 1 && isReversed == false)
        {
            m_Rigidbody.rotation += 1f;
        }

        if (spinningSpeed == 0 && isReversed == true)
        {
            m_Rigidbody.rotation -= 2f;
        }
        if (spinningSpeed == 2 && isReversed == true)
        {
            m_Rigidbody.rotation -= 4f;
        }
        if (spinningSpeed == 1 && isReversed == true)
        {
            m_Rigidbody.rotation -= 1f;
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            m_Rigidbody.position += new Vector2(-5 * Time.fixedDeltaTime, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            m_Rigidbody.position += new Vector2(5 * Time.fixedDeltaTime, 0);
        }

        if (Input.GetAxisRaw("Vertical") == -1)
        {
            m_Rigidbody.position += new Vector2(0, -5 * Time.fixedDeltaTime);
        }
        else if (Input.GetAxisRaw("Vertical") == 1)
        {
            m_Rigidbody.position += new Vector2(0, 5 * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        lives--;
        gameObject.GetComponent<Renderer>().material.color = Color.red;

        hurttimer = 0.1f;


        //Debug.Log("we hebben iets geraakt");




    }

    private void OnCollisionStay2D(Collision2D collision)
    {

   
    }







}
