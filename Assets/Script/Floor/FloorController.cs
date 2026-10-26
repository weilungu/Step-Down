using System;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // Awake
    FloorRise rise;
    
    // Inspector
    [SerializeField] float destroyTime = 5f;
    
    // === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<FloorRise>();
    }

    void Update()
    {
        rise.Rise();
        
        Destroy(gameObject, destroyTime);
    }
}
