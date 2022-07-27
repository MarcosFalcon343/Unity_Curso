using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100;
    private float damage = 2f;
    private float cure = 3f;
    public float speed = 1;
    private float xz;
    public Vector3 dir;

    //Varaible de ayuda a visualizar
    private bool check = false;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EJECUTANDO EL START");
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log("EJECUTANDO EL UPDATE");
        move(dir);
        //Sentencia de control para desmostrar los metodos
        if(check == false)
        {
            hurt(damage);
        }else if(check == true)
        {
            heal(cure);
        }

        if(health >= 100)
        {
            check = false;
        }else if(health <= 0)
        {
            check = true;
        }
    }

    //Metodo para subir la vida al objeto
    void heal(float sanar)
    {
        health = health + sanar;
    }

    //Metodo para bajar la vida al objeto
    void hurt(float herir)
    {
        health = health - herir;
    }

    //Metodo para mover un objeto en los 3 ejes (XYZ)
    void move(Vector3 direction)
    {
        rotation(direction);
        transform.position += direction * speed * Time.deltaTime;
    }

    /*Metodo para rotar el objeto en los ejes
    Solo es estetico y falta mejorar*/
    void rotation(Vector3 ejes)
    {
        xz = (Mathf.Atan(ejes.x / ejes.z) * 180) / 3.1416f;

        transform.rotation = Quaternion.Euler(0, xz, 0);
    }
}
