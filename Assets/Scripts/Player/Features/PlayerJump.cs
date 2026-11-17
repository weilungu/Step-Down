using System;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Component
    Rigidbody2D rb;
    
    // Inspector
    [SerializeField, Range(1f, 10f)] float speed = 1f;
    
    // === Life cycle === //
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // === API === \\
    public void Jump()
    {
        rb.linearVelocity = Vector2.up * speed;
        // rb.AddForceY(speed, ForceMode2D.Impulse);

        print("Player Jump");
    }
}
