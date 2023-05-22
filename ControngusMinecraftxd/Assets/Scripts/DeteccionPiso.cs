using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionPiso : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Piso"))
        {
            MovJugador.TouchPiso = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        MovJugador.TouchPiso = false;
    }
}
