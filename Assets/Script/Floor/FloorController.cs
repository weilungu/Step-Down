using System;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    [SerializeField, Range(0f, 15f)] float riseSpeed = 1f;
    
    [Header("Debugger")]
    [SerializeField] bool limited;
    
    // === Life Cycle === //
    void Update()
    {
        Rise();
    }

    void LateUpdate()
    {
        if (limited)
            Limit();
    }


    // === Method === //
    void Rise()
    {
        Vector2 movement = Vector2.up * riseSpeed;
        
        transform.Translate(movement * Time.deltaTime);
    }

    void Limit()
    {
        if (transform.position.y > 5)
            transform.position = Vector3.up * -5;
    }
}
