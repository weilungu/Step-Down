using System;
using UnityEngine;

public class TimerMachine : MonoBehaviour
{
    float timer;
    
    void Update()
    {
        timer += Time.deltaTime;
    }
    
    // === API === \\
    public bool Tip(float interval)
    {
        if (timer >= interval)
        {
            timer -= interval;
            return true;
        }
        return false;
    }
}
