using System;
using UnityEngine;

public class Platform_Bouncy : Platform
{
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
