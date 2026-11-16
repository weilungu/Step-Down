using System;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    // Component
    TimerMachine timer;
    PlatformSpawner spawner;
    
    
    // === Life Cycle === \\
    void Awake()
    {
        timer = GetComponent<TimerMachine>();
        spawner = GetComponentInChildren<PlatformSpawner>();
    }

    void Update()
    {
        if (timer.Tip(1))
            spawner.Spawn();
    }
}
