using System;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Component
    protected PlayerController player;
    
    // === Events === //
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject.GetComponent<PlayerController>();
            player.currPlatform = gameObject;
            Features();
        }
    }
    
    protected virtual void Features()
    {
        // 回血
        print("回血");
    }
}
