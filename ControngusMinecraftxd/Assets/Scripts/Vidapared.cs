using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidapared : MonoBehaviour

{
    public int health = 100;
    public int damage = 10;

    public GameObject paredd;
    public GameObject[] puerta;

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
            for (int i = 0; i < puerta.Length; i++)
            {
                Destroy(puerta[i]);
            }
            paredd.GetComponent<MovPared>().moverxd();
            Destroy(gameObject);
            Debug.Log("Pared Destruida");
        }
    }
}
