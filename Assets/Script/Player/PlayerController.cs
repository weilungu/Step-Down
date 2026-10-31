using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerInputHandler input;

    void Awake()
    {
        input = GetComponent<PlayerInputHandler>();
    }
}
