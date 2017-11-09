using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Canvas worldOne;
    public Canvas worldTwo;
    public Canvas worldThree;
    public Canvas worldFour;
    public Canvas worldSelectIce;
    public Canvas worldSelectSand;
    public Canvas worldSelect;

    public Canvas worldFive;
    public Canvas worldSix;
    public Canvas worldSeven;
    public Canvas worldEight;

    public Button worldOnebtn;
    public Button worldTwobtn;
    public Button worldThreebtn;
    public Button worldFourbtn;
    public Button worldFivebtn;
    public Button worldSixbtn;
    public Button worldSevenbtn;
    public Button worldEightbtn;
    public Button worldSand;

    public GameObject desertPrompt;

    void Awake()
    {
        if (PlayerPrefs.GetInt("lvl 2-1") == 1)
        {
            worldTwobtn.interactable = true;
        }
        if (PlayerPrefs.GetInt("lvl 3-1") == 1)
        {
            worldThreebtn.interactable = true;

        }
        if (PlayerPrefs.GetInt("lvl 4-1") == 1)
        {
            worldFourbtn.interactable = true;

        }
        if (PlayerPrefs.GetInt("lvl 5-1") == 1)
        {
            worldFivebtn.interactable = true;
            worldSand.interactable = true;

        }
        if (PlayerPrefs.GetInt("lvl 6-1") == 1)
        {
            worldSixbtn.interactable = true;

        }
        if (PlayerPrefs.GetInt("lvl 7-1") == 1)
        {
            worldSevenbtn.interactable = true;

        }
        if (PlayerPrefs.GetInt("lvl 8-1") == 1)
        {
            worldEightbtn.interactable = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    #region Ice Levels

    public void EnterWorldOne()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldOne.enabled = true;

        worldSelectIce.enabled = false;
    }

    public void EnterWorldTwo()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldTwo.enabled = true;

        worldSelectIce.enabled = false;
    }

    public void EnterWorldThree()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldThree.enabled = true;

        worldSelectIce.enabled = false;
    }

    public void EnterWorldFour()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldFour.enabled = true;

        worldSelectIce.enabled = false;
    }

    #endregion

    public void EnterWorldFive()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldFive.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterWorldSix()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldSix.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterWorldSeven()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldSeven.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterWorldEight()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldEight.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterIceWorlds()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldSelectIce.enabled = true;

        worldSelect.enabled = false;
    }

    public void EnterSandWorlds()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        worldSelectSand.enabled = true;    

        worldSelect.enabled = false;
    }

    public void BackButton()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        desertPrompt.SetActive(false);
        worldOne.enabled = false;
        worldTwo.enabled = false;
        worldThree.enabled = false;
        worldFour.enabled = false;

        worldSelectIce.enabled = true;
    }

    public void BackButtonSand()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        desertPrompt.SetActive(false);
        worldFive.enabled = false;
        worldSix.enabled = false;
        worldSeven.enabled = false;
        worldEight.enabled = false;

        worldSelectSand.enabled = true;
    }

    public void BackToWorldSelect()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        desertPrompt.SetActive(false);
        worldSelectIce.enabled = false;
        worldSelectSand.enabled = false;

        worldSelect.enabled = true;
    }

    public void BackToMainMenu()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        SceneManager.LoadScene(0);
    }
}
