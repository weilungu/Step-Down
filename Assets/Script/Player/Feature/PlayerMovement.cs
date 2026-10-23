using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Awake
    Rigidbody2D rb;
    
    // Inspector
    [SerializeField, Range(1f, 25f)] float speed = 1f;
    
    // Private
    Vector2 direction;
    
    
    // === Life Cycle === //
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // === API === //
    public void Movement()
    {
        Vector2 movement = direction * speed;
        
        rb.linearVelocity = movement;
        // transform.Translate(movement * Time.deltaTime);
    }
    
    
    // Set
    public void SetDirection(Vector2 dir) => direction = dir;

    
    // Get
    public Vector2 Direction => direction;
    public float Speed => speed;
}
