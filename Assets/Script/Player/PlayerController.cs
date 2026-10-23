using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Awake
    PlayerMovement move;
    
    
    // === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        move.Movement();
    }
}
