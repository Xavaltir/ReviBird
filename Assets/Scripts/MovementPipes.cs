﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPipes : MonoBehaviour
{

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
