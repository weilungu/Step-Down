using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext ctx)
    {
        print(ctx);
    }
}
