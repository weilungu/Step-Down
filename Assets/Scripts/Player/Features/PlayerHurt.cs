using UnityEngine;

public class PlayerHurt : MonoBehaviour
{
    // PlayerHurt

    PlayerController player;

    void Awake()
    {
        player = GetComponent<PlayerController>();
    }

    public void Hurt()
    {
        if (player.currHp <= 0)
            return;

        player.currHp--;
        player.hpBar[player.currHp].SetActive(false);

        print("扣血");
    }

}
