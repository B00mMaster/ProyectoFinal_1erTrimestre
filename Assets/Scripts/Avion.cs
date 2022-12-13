using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{
    public float speed = 0.8f;

    private void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}
