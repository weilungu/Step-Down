using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    // Inspector
    [SerializeField] GameObject floor;
    [SerializeField] GameObject[] spawnPoints;
    
    [Header("Time Setting")]
    public float interval = 1f;
    
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
