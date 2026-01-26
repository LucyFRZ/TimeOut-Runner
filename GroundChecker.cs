using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGround;

    //Lleva la cuenta de la cantidad de objetos del suelo que esta tocando el personaje.
    public int groundElements;

     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            groundElements++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            groundElements--;
        }
    }
    public void Update()
    {
        if (groundElements > 0)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }
}
