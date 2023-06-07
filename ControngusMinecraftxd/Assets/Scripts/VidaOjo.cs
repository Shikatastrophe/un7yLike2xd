using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaOjo : MonoBehaviour

{

    Formulas formulas;

    public int health = 100;
    public int damage = 10;

    public GameObject torretas;

    public GameObject[] toDespawn;

    public GameObject player;

    private void Update()
    {
        formulas = new Formulas();
    }
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
            Win();
            
        }
    }

    public void Win()
    {
        for (int i = 0; i < toDespawn.Length; i++)
        {
            Destroy(toDespawn[i]);
        }
        player.transform.position = formulas.Translacion(player.transform.position, new Vector3(1.15f, 10.5f, 1.4f));
        Debug.Log("Ganaste el Juego!!!");
    }
}
