using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    PlayerMovement move;
    Destroyer destroyer;
    
    // Private Values
    GameObject currPlatform;

    
    // === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
        destroyer = GetComponent<Destroyer>();
    }

    void Update()
    {
        destroyer.DestroyAtHeight(isPositive: false);
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
