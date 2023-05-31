using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject Inicio;

    public GameObject BalaPrefab;

    public float Vel;

    public float coolDown;

    private float tiSigDis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiSigDis > 0)
        {
            tiSigDis -= Time.deltaTime;
        }

        if (Input.GetButton("Fire1") && tiSigDis <= 0)
        {
            sfxPlayer.Instance.Gunsfx();

            GameObject BTemp = Instantiate(BalaPrefab, Inicio.transform.position, gameObject.transform.rotation) as GameObject;

            Rigidbody rb = BTemp.GetComponent<Rigidbody>();

            //rb.AddForce(transform.forward * Vel);
            rb.AddForce(transform.right * Vel);

            Destroy(BTemp, 2.0f);
            tiSigDis = coolDown;
        }
    }
}
