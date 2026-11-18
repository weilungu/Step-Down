using UnityEngine;

public class Platform_Bouncy : Platform
{
    // Platform_Bouncy
    PlayerJump jump;

    protected override void Features()
    {
        base.Features();

        // Player Components
        jump = player.GetComponent<PlayerJump>();

        // Logics
        jump.Jump();
    }
}
