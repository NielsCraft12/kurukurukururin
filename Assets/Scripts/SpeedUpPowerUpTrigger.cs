using UnityEngine;

public class SpeedUpPowerUpTrigger : MonoBehaviour
{
    public player players;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            players.spinningSpeed = 2;
        }
    }

}
