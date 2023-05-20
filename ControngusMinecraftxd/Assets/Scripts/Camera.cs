using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Camera : MonoBehaviour
{
    public GameObject ply;
    Formulas formulas;
    public float x, y, z, w;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float hor = Input.GetAxis("Mouse X");
        formulas = new Formulas();
        gameObject.transform.position = formulas.Quaternion(new Vector3(x, y, z), hor*w, gameObject.transform.position);
    }
}
