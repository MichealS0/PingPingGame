using UnityEngine;

public class _PongsScriptL1 : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Rigidbody2D rbL;

    [Header("Game Settings")]
    [SerializeField] private float moveSpeed;

    void Start()
    {
        rbL = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rbL.velocity = new Vector2(0f, -moveSpeed);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rbL.velocity = new Vector2(0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbL.velocity = new Vector2(0f, moveSpeed);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rbL.velocity = new Vector2(0f, 0f);
        }
    }

    // -- Back At It Again
}
