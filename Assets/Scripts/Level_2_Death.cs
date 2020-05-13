using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_2_Death : MonoBehaviour
{
    //https://www.youtube.com/watch?v=mCAXYOwCgCY


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level_0");
        }
    }
}

