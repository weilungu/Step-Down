using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Awake
    SpriteRenderer sprite;
    PlayerInputHandler input;
    
    PlayerMovement move;
    
    // Inspector
    [SerializeField] Color loseColor = Color.red;
    
    // Private
    GameObject currFloor;
    
    
    // === Life Cycle === //
    void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        input = GetComponent<PlayerInputHandler>();
        
        move = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        move.Movement();
    }
    
    
    // Event
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
            currFloor = other.gameObject;
        
        
        if (other.gameObject.CompareTag("Ceiling"))
        {
            BoxCollider2D floorCollider = currFloor.GetComponent<BoxCollider2D>();

            floorCollider.enabled = false;
            sprite.color = loseColor;
            input.DisableMove();
            
            print("Collision Ceiling");
        }
    }
}
