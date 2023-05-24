using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{
    public Vector3 eje;
    public float angle;
    Formulas formulas;
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
        bool islookingUp = false;

        if (vertical > 0.1f)
        {
            if (!islookingUp)
            {
                gameObject.transform.position = formulas.Quaternion(eje, angle, gameObject.transform.position);
                islookingUp = true;
            }
        }
        if (vertical == 0)
        {
            islookingUp = false;
        }

    }
}
