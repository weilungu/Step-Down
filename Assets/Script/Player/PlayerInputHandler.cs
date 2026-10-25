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
    // Enable
    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (!movement.CanMove) return;
        
        Vector2 dir = ctx.ReadValue<Vector2>();
        movement.SetMoveDirection(dir);
        
        if (ctx.performed)
            print("on move");
    }
    
    // Disable
    public void DisableMove()
    {
        movement.CanMove = false;
    }
}
