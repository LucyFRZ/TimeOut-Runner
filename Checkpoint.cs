using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public float extraTime;

    //Para comprobar si el jugador ya ha entrado al checkpoint
    public bool used;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (used == false)
            {
                used = true;

                GameManager.instance.timeToCompleteLevel += extraTime;

            }
        }
    }
}
