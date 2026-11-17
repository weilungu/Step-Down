using System;
using UnityEngine;

public class PlayerHurt : MonoBehaviour
{
    PlayerController player;

    void Awake()
    {
        player = GetComponent<PlayerController>();
    }

    public void Hurt()
    {
        // 扣血
        if (player.currHp <= 0) 
            return;
        
        player.currHp--;
        player.hpBar[player.currHp].SetActive(false);
        
        print("扣血");
    }
}
