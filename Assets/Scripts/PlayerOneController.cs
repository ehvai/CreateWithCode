using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    // Private variables
    public string inputID;
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    // Start is called before the first frame update
    void Start()
    {
                mainCamera.enabled = true;
                hoodCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


        // Gets the player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Change camera view
        if (Input.GetKeyDown(switchKey))
        {
            if(mainCamera.enabled)
            {
                mainCamera.enabled = false;
                hoodCamera.enabled = true;
            }
            else
            {
                mainCamera.enabled = true;
                hoodCamera.enabled = false;
            }

        }
    }
}
