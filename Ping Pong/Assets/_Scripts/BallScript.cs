using UnityEngine;

public class BallScript : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Game Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float RoundSpeedMultiplyer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(speed, 0f));
    }


    void FixedUpdate()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        speed = -speed;
    }

    // -- Back At It Again
}
