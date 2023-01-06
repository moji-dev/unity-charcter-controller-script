using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControllerScript : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform orientation;
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

    // Apply the movement direction to the player's position
    transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
