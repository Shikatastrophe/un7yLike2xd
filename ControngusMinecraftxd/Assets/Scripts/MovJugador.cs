using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    Formulas formulas;
    public float speed = 2;
    public GameObject PuntoA;
    public GameObject PuntoB;

    public GameObject pies;
    public Rigidbody rb;
    public float FuerzaSalto;

    public static bool TouchPiso=false;

    BoxCollider box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        formulas = new Formulas();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(gameObject.transform.position.x+1, gameObject.transform.position.y+1, gameObject.transform.position.z+1));

        //Debug.Log("horizontal"+horizontal);
        //Debug.Log("vertical"+vertical);

        if (horizontal < -0.1f && gameObject.transform.position.z > PuntoA.transform.position.z)
        {
            //Debug.Log("Izq");
            //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.000001f));
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z-0.1f);
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(PuntoA.transform.position.x, PuntoA.transform.position.y, PuntoA.transform.position.z*0.01f));
        }
        if (horizontal > 0.1f && gameObject.transform.position.z < PuntoB.transform.position.z)
        {
            //Debug.Log("der");
            //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 0.000001f));
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z+0.1f);
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(PuntoB.transform.position.x, PuntoB.transform.position.y, PuntoB.transform.position.z*0.01f));
        }
        if (vertical > 0.1f)
        {
            gameObject.transform.Rotate(0,0,5);
            //Debug.Log("Adel");
            //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(gameObject.transform.position.x + 0.000001f, gameObject.transform.position.y, gameObject.transform.position.z));
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x+0.1f, gameObject.transform.position.y, gameObject.transform.position.z);

        }
        if (vertical < -0.1f)
        {
            //Debug.Log("Atra");
            //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(gameObject.transform.position.x - 0.000001f, gameObject.transform.position.y, gameObject.transform.position.z));
            //gameObject.transform.position = new Vector3(gameObject.transform.position.x-0.1f, gameObject.transform.position.y, gameObject.transform.position.z);

        }
        if (vertical == 0)
        {
            gameObject.transform.Rotate(0, 0, 0);
        }


        if (Input.GetButton("Jump") && TouchPiso)
        {
            rb.AddForce(transform.up * FuerzaSalto);
        }

        box = GetComponent<BoxCollider>();

        if (Input.GetButton("CRTL"))
        {

            box.center = new Vector3(box.center.x, 1.6f, box.center.z);
        }
        else
        {
            box.center = new Vector3(box.center.x, 0.9782128f, box.center.z);
        }
    }


}
