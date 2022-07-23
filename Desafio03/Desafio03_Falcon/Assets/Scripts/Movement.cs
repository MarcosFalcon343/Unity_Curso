using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 2f;
    public float damage = 100f;
    private float hp = 1000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void hurt(float dano)
    {
        hp = hp - dano;
    }
}

