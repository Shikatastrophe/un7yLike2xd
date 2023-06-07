using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject L2R;
    public GameObject R2L;

    public Transform SpawnerDerecha;
    public Transform SpawnerIzquierda;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int num = Random.Range(1, 750);
        if (num == 1)
        {
            Right();
        }
        if (num == 2)
        {
            Left();
        }
    }

    void Right()
    {
        Instantiate(R2L, SpawnerIzquierda.position, SpawnerIzquierda.rotation);
    }

    void Left()
    {
        Instantiate(L2R, SpawnerDerecha.position, SpawnerDerecha.rotation);
    }
}

