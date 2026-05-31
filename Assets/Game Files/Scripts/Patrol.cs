using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public List<Transform> patrolLocations;

    public Rigidbody2D enemy;
    public int CurrentLocation;
    public float ChaseTime;
    public float CurrentChaseTime = 0;
    public Transform PlayerLocation;
    public Vector2 dir;
    public float Speed;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentLocation = 0;
   
    }

    // Update is called once per frame
    void Update()
    {
        
       enemy.transform.LookAt(patrolLocations[CurrentLocation].position);
       


    enemy.AddForce(enemy.transform.forward * Speed);


        CurrentChaseTime += Time.deltaTime;
        if (CurrentChaseTime > ChaseTime)
        {
            CurrentChaseTime = 0;
            CurrentLocation++;
            if (CurrentLocation >= patrolLocations.Count)
                CurrentLocation= 0;


        }
    }
}
