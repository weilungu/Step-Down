using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
// PlayerInputHandler

// Components
    PlayerMovement movement;

// === Life Cycle === //
    void Awake()
    {
        movement = GetComponent<PlayerMovement>();
    }

// === Enable API === //
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 dir = ctx.ReadValue<Vector2>();
        movement.SetMoveDirection(dir);
    }


}
