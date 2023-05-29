using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public enum SpawnState { SPAWING, WAITING, COUNTING};
    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;
    public float timebetweenwaves = 5f;
    public float wavecountdown;
    private float searchcountdown = 1f;

    public SpawnState state = SpawnState.COUNTING;
    private void Start()
    {
        wavecountdown = timebetweenwaves;
    }
    private void Update()
    {
        if(state == SpawnState.WAITING)
        {
            if(!EnemyIsAlive())
            {
                Debug.Log("ola completada");
                return;
            }
            else
            {
                return;
            }
        }
        if(wavecountdown <=0)
        {
            if(state != SpawnState.SPAWING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            wavecountdown -= Time.deltaTime;
        }
    
    }
    bool EnemyIsAlive()
    {
        searchcountdown -= Time.deltaTime;
        if (searchcountdown <= 0f)
        {
            searchcountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
       
        return true;
    }
    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("spawneando ola: " + _wave.name);
        state = SpawnState.SPAWING;
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }
        state = SpawnState.WAITING;
        yield break;
    }
    void SpawnEnemy(Transform _enemy)
    {
        Instantiate(_enemy, transform.position, transform.rotation); //hacer que spawneen en otro lugar ahorita spawnean en (0,0,0)
        Debug.Log("Spawning Enemy:" + _enemy.name);// hacer mas enemigos

    }
    
}
