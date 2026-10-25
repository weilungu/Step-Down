using System;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // Awake
    FloorRise rise;
    FloorDebugger debugger;
    
    
    // === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<FloorRise>();
        debugger = GetComponent<FloorDebugger>();
    }

    void Update()
    {
        rise.Rise();
        
        if (debugger.limited && transform.position.y >= debugger.spacing)
            debugger.Limit();
    }
}
