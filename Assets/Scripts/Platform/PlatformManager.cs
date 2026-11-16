using System;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    // Component
    TimerMachine timer;
    PlatformSpawner spawner;
    
    // Private Values
    float spawnInterval;
    
    // === Life Cycle === \\
    void Start()
    {
        spawnInterval = (float)(100 - spawner.frequency) / 100;
    }
    
    void Awake()
    {
        timer = GetComponent<TimerMachine>();
        spawner = GetComponentInChildren<PlatformSpawner>();
    }

    void Update()
    {
        if (timer.Tip(spawnInterval))
            spawner.Spawn();
    }
}
