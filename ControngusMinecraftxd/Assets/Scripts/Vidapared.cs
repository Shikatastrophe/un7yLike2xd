using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidapared : MonoBehaviour

{
    public int health = 100;
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            LoseHealth(damage);
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
