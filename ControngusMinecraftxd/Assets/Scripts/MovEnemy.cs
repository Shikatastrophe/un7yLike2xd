using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemy : MonoBehaviour
{
    Formulas formulas;

    public GameObject PuntoA;
    public GameObject PuntoB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        formulas = new Formulas();
        if (gameObject.transform.position.z > PuntoA.transform.position.z)
        {
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(PuntoA.transform.position.x, PuntoA.transform.position.y, PuntoA.transform.position.z * 0.01f));
        }
        else if (gameObject.transform.position.z < PuntoB.transform.position.z)
        {
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(PuntoB.transform.position.x, PuntoB.transform.position.y, PuntoB.transform.position.z * 0.01f));
        }

    }
}
