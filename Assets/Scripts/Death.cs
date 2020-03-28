﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    //https://www.youtube.com/watch?v=mCAXYOwCgCY


    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag ("Enemy"))
        {
            Destroy(gameObject); 
        }
    }
}