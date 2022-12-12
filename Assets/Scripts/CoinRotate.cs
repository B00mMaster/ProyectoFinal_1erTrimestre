using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Rotate(0, speed, 0, Space.World);
    }
}
