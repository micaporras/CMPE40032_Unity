using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeForward : MonoBehaviour
{
    // Variable for game objects
    public float speed = 40.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // Make a game object move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
