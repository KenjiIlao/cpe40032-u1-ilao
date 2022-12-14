using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
      
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //ROTATE THE VEHICLE
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
   
    }
}