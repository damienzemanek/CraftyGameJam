using System;
using UnityEngine;

public class KillCollide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        UI.Instance.deathScreen.SetActive(true);
        Application.LoadLevel(Application.loadedLevel);
    }
}
