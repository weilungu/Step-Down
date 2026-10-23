using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Awake
    Rigidbody2D rb;
    
    // Inspector
    [SerializeField, Range(0f, 25f)] float speed = 1f;
    
    // Private
    Vector2 moveDir, currDir;
    
    
    // === Life Cycle === //
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // === API === //
    public void Movement()
    {
        Vector2 movement = (moveDir * speed) + (Vector2.up * rb.linearVelocityY);
        
        rb.linearVelocity = movement;
    }
    
    
    // Set
    public void SetMoveDirection(Vector2 dir)
        => moveDir = dir;

    
    // Get
    public Vector2 MoveDirection => moveDir;
    public float Speed => speed;
}
