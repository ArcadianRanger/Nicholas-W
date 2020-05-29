﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("In Start Game");
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit ();
    }
}
