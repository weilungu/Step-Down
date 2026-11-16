using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Inspector Values
    [SerializeField, Min(0f)] float destroyTime;
    [Space]
    
    [SerializeField] float destroyPositonY;
    
    
    // === API === \\
    public void DestroyAtHeight(bool isPositive)
    {
        float targetHeight, currentHeight;
        targetHeight = destroyPositonY;
        currentHeight = transform.position.y;

        bool higherThanTarget, lowerThanTarget;
        higherThanTarget = currentHeight >= targetHeight;
        lowerThanTarget = currentHeight <= targetHeight;

        
        if (isPositive && higherThanTarget ||
            !isPositive && lowerThanTarget)
        {
            Destroy(gameObject);
        }

    }

    public void DestroyAfterTime()
        => Destroy(gameObject, destroyTime);
}
