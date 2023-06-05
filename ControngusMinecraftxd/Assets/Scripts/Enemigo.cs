using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject PuntoA;
    public GameObject PuntoB;
    private Rigidbody rb;
    private Transform Posicion;
    public float velocidad;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Posicion = PuntoB.transform;


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 punto = Posicion.position - transform.position;
        if(Posicion == PuntoB.transform)
        {
            rb.velocity = new Vector2(velocidad, 0);
        }
    }
}
