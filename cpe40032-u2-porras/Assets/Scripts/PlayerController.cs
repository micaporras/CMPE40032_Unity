using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables for the player
    private float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15;
    public GameObject projectilePrefab;
   
    void Start()
    {
        
    }

    void Update()
    {   // Keep the player in bounds
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            // Launch a projectile from a player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

    }
}
