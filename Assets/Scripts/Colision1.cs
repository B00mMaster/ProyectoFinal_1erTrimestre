using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision1 : MonoBehaviour
{
    private int coins;


    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Coin"))
        {//si se detecta un objeto con dicho nombre, se detectar� como falso por lo que se dejar� de ver
            other.gameObject.SetActive(false);
           

            //cada vez que se toquen los objetos se ir�n sumando de 1 en 1 enla frase
            coins++;
            Debug.Log($"You have colected {coins} coins");
        }


    }
}
