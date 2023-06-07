using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemy : MonoBehaviour
{
    public GameObject Inicio;

    public GameObject BalaPrefab;

    public float Vel;

    public float coolDown;

    private float tiSigDis;

    public string tagsss = "Player";

    public GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (tiSigDis > 0)
        {
            tiSigDis -= Time.deltaTime;
        }

        if (tiSigDis <= 0)
        {

            GameObject BTemp = Instantiate(BalaPrefab, Inicio.transform.position, gameObject.transform.rotation) as GameObject;

            Rigidbody rb = BTemp.GetComponent<Rigidbody>();

            

            rb.AddForce(transform.forward * Vel);

            Destroy(BTemp, 2.0f);
            tiSigDis = coolDown;
        }
        transform.LookAt(jugador.transform.position);
    }
}
