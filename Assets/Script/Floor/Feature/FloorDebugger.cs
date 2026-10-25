using UnityEngine;

public class FloorDebugger : MonoBehaviour
{
    [Header("Setting")]
    public float spacing = 5;
    
    [Header("Debug")]
    public bool limited;
    
    
    // === API === //
    public void Limit()
    {
        transform.position = Vector3.up * -spacing;
    }
}
