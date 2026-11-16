using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // PlayerMovement

// Component
    Rigidbody2D rb;

// Inspector Values
    [Header("Speed")]
    [SerializeField, Range(0f, 25f)] float speed = 1f;

// Private Values
    Vector2 moveDir; // Direction


// === Life Cycle === //
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


// === API === //
    public void Movement()
    {
        Vector2 movement =
            (moveDir * speed) + (Vector2.up * rb.linearVelocityY);

        rb.linearVelocity = movement;
    }

    public void SetMoveDirection(Vector2 dir)
        => moveDir = dir;

}
