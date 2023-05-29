using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidapared : MonoBehaviour
{
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            GameManager.Instance.LoseHealth(25);
        }
        
    }
    /*
    public static void Vida()
    {
        Destroy(gameObject);
    }*/
}
