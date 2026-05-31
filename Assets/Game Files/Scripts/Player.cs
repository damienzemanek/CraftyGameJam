using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    public float speed = 10f;
    public Rigidbody2D rb;
    public bool w, a, s, d;

    public Action onWallSwitch;
    
    void Update()
    {
    w = Input.GetKey(KeyCode.W);
        a = Input.GetKey(KeyCode.A);
        s = Input.GetKey(KeyCode.S);
        d = Input.GetKey(KeyCode.D);
        if (Input.GetKeyDown(KeyCode.Space))
            onWallSwitch?.Invoke();

    }


    private void FixedUpdate()
    {
        Vector3 dir = Vector3.zero;
        if (w) dir += transform.up;
        if (s) dir -= transform.up;
        if (a) dir -= transform.right;
        if (d) dir += transform.right;
        rb.AddForce(dir.normalized * speed, ForceMode2D.Force);

       
    }
}
