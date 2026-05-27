using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Collect : MonoBehaviour
{
    public UnityEvent onCollect = new UnityEvent();
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        onCollect?.Invoke();
    }
}
