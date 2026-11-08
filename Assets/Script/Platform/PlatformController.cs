using System;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    // Awake
    PlatformRise rise;
    
    // Inspector
    [SerializeField] float destroyTime = 5f;
    
    // === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<PlatformRise>();
    }

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        rise.Rising();
    }
}
