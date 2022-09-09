using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallScript : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Rigidbody2D rb;
    // The UI Score for the Right
    [SerializeField] private TMP_Text rightScore;
    //The UI Score for the Left
    [SerializeField] private TMP_Text leftScore;

    [Header("Game Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float RoundSpeedMultiplyer;
    [SerializeField] private float MaxSpeed;
    // What the Right Player's score is
    [SerializeField] private float RightPlayerScore;
    // What the Left Player's score is
    [SerializeField] private float LeftPlayerScore;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(speed, 0f));
    }
    
    void LeftConcede()
    {
        rb.transform.position = new Vector2(0f, 0f);
        rb.AddForce(new Vector2(speed, 0f));
    }

    void RightConcede()
    {
        rb.transform.position = new Vector2(0f, 0f);
        rb.AddForce(new Vector2(-speed, 0f));
    }


    void FixedUpdate()
    {
        if (rb.velocity.magnitude > MaxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        speed = -speed;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Goal_Trigger_Left")
        {
            LeftPlayerScore++;
            leftScore.text = LeftPlayerScore.ToString();
            LeftConcede();
        }

        if (other.tag == "Goal_Trigger_Right")
        {
            RightPlayerScore++;
            rightScore.text = RightPlayerScore.ToString();
            RightConcede();
        }
    }

    // -- Back At It Again
}
