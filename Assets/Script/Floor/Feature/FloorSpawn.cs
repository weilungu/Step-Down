using UnityEngine;

public class FloorSpawn : MonoBehaviour
{
    // Inspector
    [SerializeField] GameObject floor;
    [SerializeField] GameObject[] spawnPoints;
    
    [Header("Time Setting")]
    public float interval = 1f;
    
    // === API === //
    public void SpawnFloor()
    {
        Instantiate(
            original: floor,
            position: spawnPoints[0].transform.position,
            rotation: Quaternion.identity,
            parent:   transform
        );
    }
    
    
}
