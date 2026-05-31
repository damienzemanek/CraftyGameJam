using UnityEngine;
using UnityEngine.Events;

public class LevelTransitionCollide : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        onTriggerEnter?.Invoke();
    }
}
