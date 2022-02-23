using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    public  Rigidbody2D rigidbody2D;

    public float min = 3f;
    
    void Start()
    {
        rigidbody2D.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * min * Time.deltaTime;

        if (transform.localScale.x <= 0.05f)
        {

            Destroy(gameObject);
            Debug.Log("hello");

        }
    }
}
