using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movePlayer(Vector3.right);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            shoot();
        }
    }

    private void movePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void shoot()
    {

    }
}
