using System;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Components
    PlatformRise rise;
    PlatformDestroyer destroyer;
    
    
    // === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<PlatformRise>();
        destroyer = GetComponent<PlatformDestroyer>();
    }

    void Start()
    {
        destroyer.DestroyAtTime();
    }

    void Update()
    {
        // platform rise
        rise.Rising();
        
        // platform destroyed
        destroyer.DestroyAtHeight();
    }
}
