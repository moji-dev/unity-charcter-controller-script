using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControllerScript : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        //g
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime; 
    }
}
