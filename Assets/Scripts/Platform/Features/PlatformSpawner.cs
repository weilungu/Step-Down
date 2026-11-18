using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    // PlatformSpawner

    // Inspector Values
    [SerializeField] GameObject[] platformPrefabs;
    [SerializeField] GameObject[] spawnPoints;

    [Space]
    [Range(1, 50)] public int frequency;


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
