using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
     
    }

    void OnTriggerEnter(Collider other) 
    {
        // Destroy game object when they collide
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
