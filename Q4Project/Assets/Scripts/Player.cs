// Welcome to my special hell.

using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("Movement")]
    public float moveForce = 10f; // How fast 2 start
    public float maxSpeed = 9f; // How fast two speed
    public float stopForce = 27f; // How fast too stop
    public float jumpForce = 10f; // jump
    public bool gravity = true;
    bool OnGround()
    {
        float distance = 0.1f;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance);
        return hit.collider != null;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.linearVelocity;

        // Move left
        if (InputMan.buttonA)
        {
            rb.AddForce(Vector2.left * moveForce, ForceMode2D.Force);
        }

        // The sequel to moving left: moving right!
        if (InputMan.buttonD)
        {
            rb.AddForce(Vector2.right * moveForce, ForceMode2D.Force);
        }

        // Something is now adding up!
        if ((!InputMan.buttonA && !InputMan.buttonD) ^ (InputMan.buttonA && InputMan.buttonD))
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, stopForce * Time.fixedDeltaTime);
            rb.linearVelocity = new Vector2(velocity.x, velocity.y);
        }

        // Jump
        if (InputMan.buttonW && (OnGround()))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);      
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // Clamp max horizontal speed
        velocity = rb.linearVelocity;
        velocity.x = Mathf.Clamp(velocity.x, -maxSpeed, maxSpeed);

        rb.linearVelocity = velocity;
    }
}