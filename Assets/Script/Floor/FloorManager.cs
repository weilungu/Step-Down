using System;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    // Awake
    FloorSpawn spawner;
    
    
    // Private
    float spawnTimer;
    
    
    // === Life Cycle === //
    void Awake()
    {
        spawner = GetComponent<FloorSpawn>();
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawner.interval)
        {
            spawner.SpawnFloor();
            spawnTimer = 0f;
        }
    }
}
