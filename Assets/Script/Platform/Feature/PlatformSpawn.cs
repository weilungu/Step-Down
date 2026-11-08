using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    // Inspector
    [SerializeField] GameObject floor;
    [SerializeField] GameObject[] spawnPoints;
    
    [Header("Time Setting")]
    [Range(1, 50)] public int frequency = 10;
    
    // === API === //
    public void SpawnFloor()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        
        Instantiate(
            original: floor,
            position: spawnPoints[randomIndex].transform.position,
            rotation: Quaternion.identity,
            parent:   transform
        );
    }
    
    
}
