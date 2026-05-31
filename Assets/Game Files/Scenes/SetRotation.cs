using UnityEngine;

public class SetRotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0); 
    }
}
