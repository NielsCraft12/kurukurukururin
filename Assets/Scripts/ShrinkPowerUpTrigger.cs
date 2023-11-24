using UnityEngine;

public class ShrinkPowerUpTrigger : MonoBehaviour
{

    [SerializeField] private  float shrinkTimer = 10;
    public player players;
    [SerializeField] private bool infinateTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (players.srinked == true)
       {
            if (!infinateTime)
            {
        shrinkTimer -= Time.deltaTime;

            }

        }

        if (shrinkTimer <= 0)
        {
            shrinkTimer = 10;
                players.srinked = false;
        }






    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           players.srinked = true;
            gameObject.SetActive(false);
        }
    }
}
