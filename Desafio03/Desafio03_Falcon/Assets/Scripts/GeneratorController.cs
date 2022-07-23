using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", delaySpawn, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform);
    }
}