using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public float jumpForce;

    public Rigidbody2D rb;
    
    public Vector2 dir;

    public GroundChecker groundchecker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(groundchecker.isGround == true)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);
                rb.AddForce(Vector2.up * jumpForce); 
            }
            
        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(dir.x * speed, rb.linearVelocity.y);
    }
}
