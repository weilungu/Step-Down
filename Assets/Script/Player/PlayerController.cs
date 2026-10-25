using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Awake
    PlayerMovement move;
    
    // Private
    GameObject currFloor;
    
    // === Life Cycle === //
    void Awake()
    {
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
            print("Collision Ceiling");
        }
    }
}
