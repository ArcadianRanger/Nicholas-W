﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2_Movements : MonoBehaviour
{
    public float Speed = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}