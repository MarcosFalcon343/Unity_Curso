using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float waitingTime = 2f;
    public float repetitionTime = 2f;

    void Start()
    {
        InvokeRepeating("SpawnObject", waitingTime, repetitionTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnObject()
    {
        Instantiate(bullet, transform);
    }

}
