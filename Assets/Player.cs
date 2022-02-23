using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 600f;

    float movement = 0f;


    void Update()
    {

        movement = Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero,Vector3.forward,movement * Time.fixedDeltaTime * -speed);
    }
}

