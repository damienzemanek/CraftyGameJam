using System;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWall : MonoBehaviour
{
    public int current;
    public List<GameObject> states;
    public Player player;

    void Start()
    {
        DisableAllStates();
        states[current].SetActive(true);
    }

    void OnEnable() => player.onWallSwitch += Switch;
    void OnDisable() => player.onWallSwitch -= Switch;

    void DisableAllStates()
    {
        foreach (var state in states)
            state.SetActive(false);
    }

    void Switch()
    {
        DisableAllStates();
        current = (current + 1) % states.Count;
        states[current].SetActive(true);
    }

}
