using System;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // Awake
    FloorRise rise;
    FloorDebugger debugger;
    
    // Inspector
    [SerializeField] float destroyTime = 5f;
    
    // === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<FloorRise>();
        debugger = GetComponent<FloorDebugger>();
    }

    void Update()
    {
        rise.Rise();
        
        Destroy(gameObject, 5f);
    }
}
