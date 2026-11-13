using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Inspector Values
    [SerializeField, Min(0f)] float destroyTime = 5f;
    [Space]
    
    [SerializeField] Vector2 destroyPositon;
    
    
    // === API === \\
    public void AtHeight()
    {
        float targetHeight = destroyPositon.y;
        float currentHeight = transform.position.y;
        
        if (currentHeight >= targetHeight)
            Destroy(gameObject);
    }

    public void AtTime()
        => Destroy(gameObject, destroyTime);
}
