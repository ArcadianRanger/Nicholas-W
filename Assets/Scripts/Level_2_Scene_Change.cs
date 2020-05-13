using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_2_Scene_Change : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Item Picked Up");
            Destroy(gameObject);
            SceneManager.LoadScene("Level_0");
        }
    }
}
