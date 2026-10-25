using UnityEngine;

public class FloorRise : MonoBehaviour
{
    [SerializeField, Range(0f, 15f)] float riseSpeed = 1f;

    
    // === API === //
    public void Rise()
    {
        Vector2 movement = Vector2.up * riseSpeed;
        
        transform.Translate(movement * Time.deltaTime);
    }
}
