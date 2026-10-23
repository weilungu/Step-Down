using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Inspector
    [SerializeField, Range(1f, 25f)] float speed = 1f;
    
    // Private
    Vector2 direction;
    
    
    // === API === //
    public void Movement()
    {
        Vector2 movement = direction * speed;
        transform.Translate(movement * Time.deltaTime);
    }
    
    
    // Set
    public void SetDirection(Vector2 dir) => direction = dir;

    
    // Get
    public Vector2 Direction => direction;
    public float Speed => speed;
}
