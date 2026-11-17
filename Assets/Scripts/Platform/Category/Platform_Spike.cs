using System;
using UnityEngine;

public class Platform_Spike : Platform
{
    protected override void Features()
    {
        hurt.Hurt();
    }
}
