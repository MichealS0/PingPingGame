using UnityEngine;

public class BallScript : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Game Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float RoundSpeedMultiplyer;
    [SerializeField] private float MaxSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(speed, 0f));
    }


    void FixedUpdate()
    {
        if (rb.velocity.magnitude > MaxSpeed)
        {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, MaxSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        speed = -speed;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Change the Score TypeShit Nigga
    }

    // -- Back At It Again
}
