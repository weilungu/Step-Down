using System;
using UnityEngine;

public class TimerMachine : MonoBehaviour
{
    float timer;
    
    
    void Update()
    {
        timer -= Time.deltaTime;
    }
    
    // === API === \\
    bool Tip(float interval)
    {
        return interval > 0;
    }
}
