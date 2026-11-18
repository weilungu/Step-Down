using UnityEngine;

public class TimerMachine : MonoBehaviour
{
    // TimerMachine

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
