using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;

    public float turnSpeed;

    private float horizontalInput;

    private float verticalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        verticalInput=Input.GetAxis("Vertical");
      
       transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);


    }























}

