using UnityEngine;

public class PlayerController : MonoBehaviour
{
// PlayerController
    
// Component
    PlayerMovement move;
    
    // Private Values
    GameObject currPlatform;

// === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        move.Movement();
    }
    
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
            currPlatform = other.gameObject;
        
        
        if (other.gameObject.CompareTag("Ceiling"))
        {
            BoxCollider2D platformCollider 
                = currPlatform.GetComponent<BoxCollider2D>();

            platformCollider.enabled = false;
            
            print("Collision Ceiling");
        }
    }

}
