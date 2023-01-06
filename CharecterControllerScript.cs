using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControllerScript : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform orientation;
    public float jumpForce = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    // Calculate the movement direction based on WASD input and the orientation Transform
    Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    movementDirection = orientation.TransformDirection(movementDirection);

    // Normalize the movement direction
    movementDirection.Normalize();

    // Increase the movement speed if the left shift key is being pressed
    float sprintMultiplier = 1.0f;
    if (Input.GetKey(KeyCode.LeftShift))
    {
        sprintMultiplier = 2.0f;
    }

    // Apply the movement direction to the player's position
    transform.Translate(movementDirection * speed * sprintMultiplier * Time.deltaTime);

    // Check if the space key is being pressed
    if (Input.GetKeyDown(KeyCode.Space))
    {
        // Apply an upward force to the player's rigidbody
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
}
