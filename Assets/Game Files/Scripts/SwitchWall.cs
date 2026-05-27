using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class SwitchWall : MonoBehaviour
{
    public int current;
    [ReadOnly] public List<GameObject> states;
    Player player => Player.Instance;
    

    void Start()
    {
        states = new List<GameObject>();
        foreach (Transform child in transform)
            states.Add(child.gameObject);
        
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
