using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPared : MonoBehaviour
{
    public GameObject nv;
    Formulas formulas;
    public float coolDown;

    public GameObject escudo;

    public float tiSigDis;

    bool mover = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        formulas = new Formulas();
        if (tiSigDis > 0 && mover)
        {
            tiSigDis -= Time.deltaTime;
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(nv.transform.position.x * 0.1f, nv.transform.position.y, nv.transform.position.z));
            escudo.SetActive(true);
        }
        if (tiSigDis <= 0)
        {
            //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(nv.transform.position.x * 0.1f, nv.transform.position.y, nv.transform.position.z));
            tiSigDis = coolDown;
            mover = false;
            escudo.SetActive(false);
        }
        
    }

    public void moverxd()
    {
        mover = true;
    }
}
