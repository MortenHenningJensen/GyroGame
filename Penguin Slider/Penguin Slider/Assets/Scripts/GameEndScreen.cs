﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEndScreen : MonoBehaviour
{
    public bool levelCompleted;
   // private GameControl control;
    public int starsUnlocked;
    //private AdTracker at;
    public Button nextLevel;
    private AdTracker at;

    public Image starOne;
    public Image starTwo;
    public Image starThree;

    private void Start()
    {
        
        at = GameObject.Find("AdTracker").GetComponent<AdTracker>();
        levelCompleted = false;
    //    control = FindObjectOfType<GameControl>();
    }

    public void BackToMenu()
    {
        at.attemptCounter += 5;

        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        Destroy(GameObject.Find("GameTracker"));

        if (levelCompleted)
        {
            SaveProgress(SceneManager.GetActiveScene().name.ToString(), starsUnlocked);
        }

        //at.attemptCounter++;
        SceneManager.LoadScene("Level Select");
    }

    private void Update()
    {
        if (levelCompleted == true)
        {
            nextLevel.interactable = true;
        }
    }

    public void ReplayLevel()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }

        at.attemptCounter += 5;

        Destroy(GameObject.Find("GameTracker"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (levelCompleted)
        {
            SaveProgress(SceneManager.GetActiveScene().name.ToString(), starsUnlocked);         
        }
        //at.attemptCounter++;
    }

    public void PlayNextLevel()
    {
        at.attemptCounter += 5;

        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        Destroy(GameObject.Find("GameTracker"));

        if (levelCompleted)
        {
            SaveProgress(SceneManager.GetActiveScene().name.ToString(), starsUnlocked);
        }

        SceneManager.LoadScene(nextSceneIndex);
    }

    public void SaveProgress(string level, int stars)
    {
        PlayerPrefs.SetInt("Level " + level, stars);
        PlayerPrefs.SetInt("lvl " + level, 1);

        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        string path = SceneUtility.GetScenePathByBuildIndex(nextSceneIndex);
        string sceneName = path.Substring(0, path.Length - 6).Substring(path.LastIndexOf('/') + 1);

        PlayerPrefs.SetInt("lvl " + sceneName, 1);
    }

    public void CheatMode()
    {
        SaveProgress(SceneManager.GetActiveScene().name.ToString(), 3);

        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
        Destroy(GameObject.Find("GameTracker"));


        SceneManager.LoadScene("Level Select");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void AreYouSurePrompt(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void AreYouSurePromptNo(GameObject obj)
    {
        obj.SetActive(false);
    }
}
