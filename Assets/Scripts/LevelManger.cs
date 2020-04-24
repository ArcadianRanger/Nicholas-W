﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene ("Wilson_Independent_Project");
    }

    public void QuitGame()
    {
        Application.Quit ();
    }
}
