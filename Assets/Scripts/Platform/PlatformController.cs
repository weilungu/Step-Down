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
        destroyer.DestroyAfterTime();
    }

    void Update()
    {
        // platform rise
        rise.Rising();
        
        // platform destroyed
        destroyer.DestroyAtHeight(isPositive: true);
    }
}
