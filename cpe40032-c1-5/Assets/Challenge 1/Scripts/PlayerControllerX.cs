using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Make the plane move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Make the plane tilt upwards or downwards
        transform.Rotate(Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);
    }
}
