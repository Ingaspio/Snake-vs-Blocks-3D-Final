using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float Hor;
    public float Speed = 5;
    public float IncreasedSpeed = 0.0001f;
    public Rigidbody Rigidbody;

    void FixedUpdate()
    {
        Speed += IncreasedSpeed;
        transform.position += transform.forward * Speed * Time.deltaTime;

        Hor = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * Hor * Speed * Time.deltaTime);
    }
}
