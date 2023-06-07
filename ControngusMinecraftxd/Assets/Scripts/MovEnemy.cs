using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemy : MonoBehaviour
{
    public GameObject enemy;
    Formulas formulas;
    public float coolDown;
    public string tags;

    public float tiSigDis;

    [SerializeField] bool mover = false;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag(tags);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        formulas = new Formulas();
        if (tiSigDis > 0 && mover)
        {
            tiSigDis -= Time.deltaTime;
            gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(enemy.transform.position.x *0, enemy.transform.position.y *0, enemy.transform.position.z * 0.01f));
            Destroy(gameObject, coolDown);
        }
        if (tiSigDis <= 0)
        {
            //gameObject.transform.position = formulas.Translacion(gameObject.transform.position, new Vector3(enemy.transform.position.x * 0.1f, enemy.transform.position.y, enemy.transform.position.z));
            tiSigDis = coolDown;
            mover = false;
        }
        mover = true;

    }

    public void moverxd()
    {
        mover = true;
        
    }
}
