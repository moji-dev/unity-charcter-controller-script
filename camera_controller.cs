using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public float sensitivity = 5.0f;
    float xrot = 0.0f;
    float yrot = 0.0f;

    public Transform orientation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    float mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
    float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime;

    yrot += mouseX*1.5f;
    xrot += mouseY*1.5f;

    xrot = Mathf.Clamp(xrot, -90f, 90f);

    transform.localRotation = Quaternion.Euler(-xrot, yrot, 0);
    orientation.rotation = Quaternion.Euler(0, yrot, 0);

    // Set the player's rotation to match the orientation Transform
    GameObject player = GameObject.FindWithTag("Player");
    player.transform.rotation = orientation.rotation;
        
       

        
    }
}
