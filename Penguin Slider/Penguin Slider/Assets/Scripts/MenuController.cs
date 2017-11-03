﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public Canvas optionsMenu;
    public Canvas howToPlay;

    private void Start()
    {

        optionsMenu.enabled = false;
        howToPlay.enabled = false;
}

    public void WorldSelect()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void OptionsSelect()
    {
        optionsMenu.enabled = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OptionsDeselect()
    {
        optionsMenu.enabled = false;
    }

    public void HowToPlay()
    {
        howToPlay.enabled = true;
    }

    public void DeselectHowToPlay()
    {
        howToPlay.enabled = false;
    }
}
