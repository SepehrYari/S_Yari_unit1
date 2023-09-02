using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //rate of back and forth motion speed
    private float Speed = 15.0f;
    private float TurnSpeed = 15.0f;

    //Input Variables
    private float horizontalInput;
    private float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        Debug.Log(Time.deltaTime);
        //moving the car
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * VerticalInput);
        //turning the car
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);
    }
}
