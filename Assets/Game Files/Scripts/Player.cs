using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;

    public Action onWallSwitch;
    
    void Update()
    {
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) dir += transform.up;
        if (Input.GetKey(KeyCode.S)) dir -= transform.up;
        if (Input.GetKey(KeyCode.A)) dir -= transform.right;
        if (Input.GetKey(KeyCode.D)) dir += transform.right;
        rb.AddForce(dir.normalized * speed, ForceMode2D.Force);
        
        if(Input.GetKeyDown(KeyCode.Space))
            onWallSwitch?.Invoke();
    }
}
