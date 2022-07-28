using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    int num;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            num = 1;
            Shoot(num);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            num = 2;
            Shoot(num);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            num = 3;
            Shoot(num);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            num = 4;
            Shoot(num);
        }
    }


    private void Shoot(int i)
    {
        if (canShoot)
        {
            switch (i)
            {
                case 1:
                    canShoot = false;
                    Instantiate(munition, transform);
                    Invoke("ResetShoot", 1f);
                    break;
                case 2:
                    canShoot = false;
                    Invoke("SpawnEnemy", 1f);
                    Invoke("SpawnEnemy", 2f);
                    Invoke("ResetShoot", 1f);
                    break;
                case 3:
                    canShoot = false;
                    Invoke("SpawnEnemy", 0.666f);
                    Invoke("SpawnEnemy", 1.333f);
                    Invoke("SpawnEnemy", 2f);
                    Invoke("ResetShoot", 1f);
                    break;
                case 4:
                    canShoot = false;
                    Invoke("SpawnEnemy", 0.5f);
                    Invoke("SpawnEnemy", 1f);
                    Invoke("SpawnEnemy", 1.5f);
                    Invoke("SpawnEnemy", 2f);
                    Invoke("ResetShoot", 1f);
                    break;
            }
        }
    }

    private void ResetShoot()
    {
        canShoot = true;
    }

    private void SpawnEnemy()
    {
        Instantiate(munition, transform);
    }
}