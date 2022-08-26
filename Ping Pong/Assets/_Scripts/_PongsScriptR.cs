using UnityEngine;

public class _PongsScriptR : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Rigidbody2D rbR;

    [Header("Game Settings")]
    [SerializeField] private float moveSpeed;

    void Start()
    {
        rbR = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            rbR.velocity = new Vector2(0f, -moveSpeed);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            rbR.velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rbR.velocity = new Vector2(0f, moveSpeed);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            rbR.velocity = new Vector2(0f, 0f);
        }
    }

    // -- Back At It Again
}
