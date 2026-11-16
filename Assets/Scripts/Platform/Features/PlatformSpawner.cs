using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    // Inspector Values
    [SerializeField] GameObject[] platformPrefabs;
    
    [Space]
    [SerializeField] GameObject[] spawnPoints;
    

    // === API === \\
    public void Spawn()
    {
        int randPlatformIdx, randSpawnIdx;
        randPlatformIdx = Random.Range(0, platformPrefabs.Length);
        randSpawnIdx = Random.Range(0, spawnPoints.Length);

        GameObject plt, point;
        plt = platformPrefabs[randPlatformIdx];
        point = spawnPoints[randSpawnIdx];
        
        Instantiate(
            original: plt,
            position: point.transform.position,
            rotation: Quaternion.identity,
            parent: point.transform
        );
    }
}
