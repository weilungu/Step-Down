using System;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    // Awake
    FloorSpawn spawner;
    
    // Inspector
    
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
        if (spawnTimer >= 1f)
        {
            spawner.SpawnFloor();
            spawnTimer = 0f;
        }
    }
}
