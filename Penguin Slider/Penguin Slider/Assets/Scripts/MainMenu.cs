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

    // Use this for initialization
    void Start()
    {
        //worldSelect.enabled = true;
        //worldOne.enabled = false;
        //worldTwo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

#region Ice Levels

    public void EnterWorldOne()
    {
        worldOne.enabled = true;

        worldSelectIce.enabled = false;
    }

    public void EnterWorldTwo()
    {
        worldTwo.enabled = true;

        worldSelectIce.enabled = false;
    }

    public void EnterWorldThree()
    {
        worldThree.enabled = true;

        worldSelectIce.enabled = false;
    }

    public void EnterWorldFour()
    {
        worldFour.enabled = true;

        worldSelectIce.enabled = false;
    }

#endregion

    public void EnterWorldFive()
    {
        worldFive.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterWorldSix()
    {
        worldSix.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterWorldSeven()
    {
        worldSeven.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterWorldEight()
    {
        worldEight.enabled = true;

        worldSelectSand.enabled = false;
    }

    public void EnterIceWorlds()
    {
        worldSelectIce.enabled = true;

        worldSelect.enabled = false;
    }

    public void EnterSandWorlds()
    {
        worldSelectSand.enabled = true;

        worldSelect.enabled = false;
    }

    public void BackButton()
    {
        worldOne.enabled = false;
        worldTwo.enabled = false;
        worldThree.enabled = false;
        worldFour.enabled = false;

        worldSelectIce.enabled = true;
    }

    public void BackButtonSand()
    {
        worldFive.enabled = false;
        worldSix.enabled = false;
        worldSeven.enabled = false;
        worldEight.enabled = false;

        worldSelectSand.enabled = true;
    }

    public void BackToWorldSelect()
    {
        worldSelectIce.enabled = false;
        worldSelectSand.enabled = false;

        worldSelect.enabled = true;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
