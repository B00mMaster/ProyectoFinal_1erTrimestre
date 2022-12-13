using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionHelice : MonoBehaviour
{
    public float speed = 0.8f;

    private void Update()
    {
        transform.Rotate(0, 0, speed);
      //colocar speed en el eje que se va a hacer la rotacion
    }
}
