using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidatorretasboss : MonoBehaviour

{
    public int health = 100;
    public int damage = 10;

    public GameObject torretas;

    public GameManager manager;

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
            manager.coreDestroyed();
        }
    }
}
