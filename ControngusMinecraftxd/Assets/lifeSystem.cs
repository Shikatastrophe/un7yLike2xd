using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lifeSystem : MonoBehaviour
{
    public LayerMask bala;
    public float range;
    public Transform hitbox;
  void Update()
    {
        Collider[] pegoBala = Physics.OverlapSphere(hitbox.position, range, bala);

        foreach (Collider bala in pegoBala)
        {

            Debug.Log("dead");
            sfxPlayer.Instance.Dedsfx();
            ded();
        }
    }

    public void ded()
    {
        GetComponent<MovJugador>().enabled = false;
        GetComponent<Disparar>().enabled = false;
        reiniciarNivel();
    }

    public void reiniciarNivel()
    {
        StartCoroutine(WaitForSeconds(4f));
    }

    IEnumerator WaitForSeconds(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnDrawGizmosSelected()
    {
        if (hitbox == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(hitbox.position, range);
    }
}

