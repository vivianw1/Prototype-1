using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle vertical
        transform.Translate(Vector3.forward * Time.deltaTime * 20 * forwardInput);
        // rotates vehicle horizontal
        transform.Rotate(Vector3.up, 20 *horizontalInput * Time.deltaTime);
    }
}
