using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        public static GameManager Instance { get; private set; }
        public int health = 100;

        private void Awake()
        {
            Instance = this;
        }

        public void LoseHealth(int ReduccionVida)
        {
            health -= ReduccionVida;
            CheckHealth();
        }

        public int CheckHealth()
        {
            return health;
        }
    
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
