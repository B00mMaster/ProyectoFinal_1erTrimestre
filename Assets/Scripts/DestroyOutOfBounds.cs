using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperLimit = 25f;

    public float lowerLimit = 0;


    private void Update()
    {

        if (transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }

    }
}
