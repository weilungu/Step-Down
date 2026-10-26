using UnityEngine;

public class FloorSpawn : MonoBehaviour
{
    [SerializeField] GameObject floor;
    
    
    // === API === //
    public void SpawnFloor()
    {
        Instantiate(
            original: floor,
            position: Vector3.zero,
            rotation: Quaternion.identity,
            parent:   transform
        );
    }
    
    
}
