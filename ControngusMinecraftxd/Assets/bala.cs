using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public Rigidbody rb;
    public Transform hitbox;
    public float range;
    public LayerMask playerEnemyLayer;
    public int damage;
    public Transform hitScan;
    
   LifeManager lifeManager;
    void Update()
    {
        Collider[] detectPlayer = Physics.OverlapSphere(hitScan.position, range, playerEnemyLayer);

        foreach (Collider player in detectPlayer)
        {
            damagePlayer();
        }
    }

    void damagePlayer()
    {
        lifeManager.TakeLife();

    }
}
