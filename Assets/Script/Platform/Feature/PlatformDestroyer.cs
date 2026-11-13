using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    // Inspector Values
    [SerializeField, Min(0f)] float destroyTime = 5f;
    [Space]
    
    [SerializeField] Vector2 destroyPositon;
    
    
    // === API === \\
    public void DestroyAtHeight()
    {
        float targetHeight = destroyPositon.y;
        float currentHeight = transform.position.y;
        
        if (currentHeight >= targetHeight)
            Destroy(gameObject);
    }

    public void DestroyAtTime()
        => Destroy(gameObject, destroyTime);
}
