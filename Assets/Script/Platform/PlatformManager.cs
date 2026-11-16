using System;
using Unity.VisualScripting;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    // Component
    PlatformSpawn spawner;
    TimerMachine timer;
    
    // Private
    float spawnInterval;
    
    
    // === Life Cycle === //
    void Awake()
    {
        spawner = GetComponent<PlatformSpawn>();
        timer = GetComponent<TimerMachine>();
    }

    void Start()
    {
        spawnInterval = (float)(100 - spawner.frequency) / 100;
    }

    void Update()
    {
        if (timer.Tip(spawnInterval))
        {
            spawner.SpawnFloor();
        }
    }
}
