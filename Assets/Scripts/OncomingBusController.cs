using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OncomingBusController : MonoBehaviour
{
    private float speed = 20.0f;
    public GameObject bus;
    public GameObject van;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
    if (bus)
    {
        speed = 40.0f;
    }

    // Move the vehicle forward based on vertical input
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
}
}
