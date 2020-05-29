using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    //https://www.youtube.com/watch?v=mCAXYOwCgCY


    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag ("Enemy"))
        {
            //Destroy(gameObject);
            SceneManager.LoadScene("Level_0");
        }
    }
}
