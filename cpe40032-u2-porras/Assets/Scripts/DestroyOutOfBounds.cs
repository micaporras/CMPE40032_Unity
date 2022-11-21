using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Variables for the game objects' boundaries
    private float topBound = 30;
    private float lowerBound = -10;

    void Start()
    {

    }

    void Update()
    {
        // Remove the object that gone past the player 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!"); // Message that will appear when the player lost
            Destroy(gameObject);
        }

    }
}
