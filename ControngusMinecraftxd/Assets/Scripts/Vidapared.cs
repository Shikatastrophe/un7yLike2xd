using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidapared : MonoBehaviour

{
    public int health = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            LoseHealth(25);
        }
    }
    public void LoseHealth(int ReduccionVida)
    {
        health -= ReduccionVida;
        CheckHealth();
    }
    public void CheckHealth()
    {
        if (health <= 0)
        {
            sfxPlayer.Instance.Explodesfx();
            Destroy(gameObject);
            Debug.Log("Pared Destruida");
        }
    }
}
