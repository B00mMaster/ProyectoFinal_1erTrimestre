using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision1 : MonoBehaviour
{
    private int coins;


    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Coin"))
        {
            other.gameObject.SetActive(false);
            coins++;
            Debug.Log($"You have colected {coins} coins");
        }


    }
}
