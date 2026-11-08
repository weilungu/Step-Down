using UnityEngine;

public class PlatformRise : MonoBehaviour
{
    [SerializeField, Range(0f, 15f)] float speed = 1f;

    
    // === API === //
    public void Rise()
    {
        Vector2 movement = Vector2.up * speed;
        
        transform.Translate(movement * Time.deltaTime);
    }
}
