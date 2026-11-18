using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    PlayerMovement move;
    Destroyer destroyer;
    
    [HideInInspector] public GameObject currPlatform;
    
    // HP
    public GameObject[] hpBar;
    [HideInInspector] public int currHp, maxHp;

    
    // === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
        destroyer = GetComponent<Destroyer>();
    }
    
    void Start()
    {
        currHp = hpBar.Length;
        maxHp = hpBar.Length;
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
        if (other.gameObject.CompareTag("Ceiling"))
        {
            BoxCollider2D platformCollider 
                = currPlatform.GetComponent<BoxCollider2D>();

            platformCollider.enabled = false;
            
            print("Collision Ceiling");
        }
    }

}
