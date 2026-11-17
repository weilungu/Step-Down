using System;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Component
    PlayerController player;
    
    // === Events === //
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject.GetComponent<PlayerController>();
            
            player.currPlatform = gameObject;
        }
    }
}
