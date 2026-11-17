using System;
using UnityEngine;

public class PlayerHeal : MonoBehaviour
{
    PlayerController player;

    void Awake()
    {
        player = GetComponent<PlayerController>();
    }

    public void Heal()
    {
        if (player.currHp >= player.maxHp)
            return;

        player.hpBar[player.currHp].SetActive(true);
        player.currHp++;

        print("回血");
    }
}
