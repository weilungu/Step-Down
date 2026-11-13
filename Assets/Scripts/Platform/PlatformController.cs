using System;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Components
    PlatformRise rise;
    Destroyer destroyer;
    
    
    // === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<PlatformRise>();
        destroyer = GetComponent<Destroyer>();
    }

    void Start()
    {
        destroyer.AtTime();
    }

    void Update()
    {
        // platform rise
        rise.Rising();
        
        // platform destroyed
        destroyer.AtHeight();
    }
}
