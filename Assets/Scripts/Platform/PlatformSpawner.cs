using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    // Inspector Values
    [SerializeField] GameObject[] platformPrefabs;
    
    [Space]
    [SerializeField] GameObject[] spawnPoints;
    
    
    // === Life Cycle === \\
    void Update()
    {
        
    }


    // === Method === \\
    void Spawn()
    {
        int randPlatformIdx = Random.Range(0, platformPrefabs.Length);
        int randSpawnIdx = Random.Range(0, spawnPoints.Length);
        
        Instantiate(
            original: platformPrefabs[randPlatformIdx],
            position: spawnPoints[randSpawnIdx].transform.position,
            rotation: Quaternion.identity
        );
    }
}
