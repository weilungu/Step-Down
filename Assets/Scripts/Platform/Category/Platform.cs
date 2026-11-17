using System;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Component
    protected PlayerController player;
    protected PlayerHurt hurt;
    protected PlayerHeal heal;
    
    // === Events === //
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Components
            player = other.gameObject.GetComponent<PlayerController>();
            hurt = other.gameObject.GetComponent<PlayerHurt>();
            heal = other.gameObject.GetComponent<PlayerHeal>();
            
            // Logics
            player.currPlatform = gameObject;
            Features();
        }
    }
    
    protected virtual void Features()
    {
        heal.Heal();
    }
}
