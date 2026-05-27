using System;
using Unity.VisualScripting;
using UnityEngine;

public class Collect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
    }
}
