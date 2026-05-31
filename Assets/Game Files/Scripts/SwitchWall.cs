using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class SwitchWall : MonoBehaviour
{
    public int startIndex;
    [ReadOnly] public int current;
    [ReadOnly] public List<GameObject> states;
    Player player => Player.Instance;
    

    void Start()
    {
        current = startIndex;
        states = new List<GameObject>();
        foreach (Transform child in transform)
            states.Add(child.gameObject);
        
        DisableAllStates();
        if(current < states.Count)
            states[current].SetActive(true);
        else 
            current = 0;
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
