using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    PlayerMovement move;
    Destroyer destroyer;
    
    // Inspector Values
    public GameObject[] hpBar;
    public int currHp, maxHp;
    
    // Public Values
    [HideInInspector]
    public GameObject currPlatform;
    
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
