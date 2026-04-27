using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    // Physics Variables
    public float xspeed; // Horizontal Movement
    public float yspeed; // Vertical Movement
    public float stopspeed = 25f; // How Fast 2 Stop
    public float jumpforce = 5f; // How High Two Jump
    public bool gravity = true; // Which way is Gravity facing?

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    void FixedUpdate()
    {
        if(InputMan.buttonA) // If pressing A, move left
        {
            xspeed = xspeed - 10f * Time.fixedDeltaTime;
        }

        if(InputMan.buttonD) // The sequel to moving left. Moving right!
        {
            xspeed = xspeed + 10f * Time.fixedDeltaTime;
        }

        if(!InputMan.buttonA && !InputMan.buttonD)
        {
            xspeed = Mathf.MoveTowards(xspeed, 0, stopspeed * Time.fixedDeltaTime);
        }

        xspeed = Mathf.Clamp(xspeed, -8.5f, 8.5f);
        rb.linearVelocity = new Vector2(xspeed, rb.linearVelocity.y);
    }
}
