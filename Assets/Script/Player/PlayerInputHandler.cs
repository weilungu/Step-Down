using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    // Awake
    PlayerMovement movement;
    
    
    // === Life Cycle === //
    void Awake()
    {
        movement = GetComponent<PlayerMovement>();
    }

    
    // === Input System === //
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 dir = ctx.ReadValue<Vector2>();
        
        movement.SetMoveDirection(dir);
    }
}
