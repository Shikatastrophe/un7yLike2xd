using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcam : MonoBehaviour
{
    Formulas formulas;
    public GameObject ply;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        formulas = new Formulas();
        if(gameObject.transform.position.z > ply.transform.position.z || gameObject.transform.position.z < ply.transform.position.z)
        {
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(ply.transform.position.x * 0, gameObject.transform.position.y * 0, ply.transform.position.z*0.1f));
        }
        if (gameObject.transform.position.z < ply.transform.position.z || gameObject.transform.position.z > ply.transform.position.z)
        {
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(ply.transform.position.x * 0, gameObject.transform.position.y * 0, ply.transform.position.z*-0.1f));
        }
    }
}
