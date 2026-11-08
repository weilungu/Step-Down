using System;
using Unity.VisualScripting;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    // Component
    PlatformSpawn spawner;
    
    // Private
    float spawnTimer;
    float spawnInterval;
    
    
    // === Life Cycle === //
    void Awake()
    {
        spawner = GetComponent<PlatformSpawn>();
        
        spawnInterval = (float)(100 - spawner.frequency) / 100;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawner.SpawnFloor();
            spawnTimer = 0f;
        }
    }
}
