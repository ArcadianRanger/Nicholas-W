﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene ("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit ();
    }
}
