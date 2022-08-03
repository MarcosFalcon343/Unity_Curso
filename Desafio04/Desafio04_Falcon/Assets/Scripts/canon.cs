using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public float destroyTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyDelay", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)){
            scale();
        }
    }

    private void scale()
    {
        transform.localScale += transform.localScale * 1f;
    }

    private void destroyDelay()
    {
        Destroy(gameObject);
    }
}
