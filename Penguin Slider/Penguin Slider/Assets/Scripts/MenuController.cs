using System.Collections;
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
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        SceneManager.LoadScene("Level Select");
    }

    public void OptionsSelect()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        optionsMenu.enabled = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OptionsDeselect()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        optionsMenu.enabled = false;
    }

    public void HowToPlay()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        howToPlay.enabled = true;
    }

    public void DeselectHowToPlay()
    {
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        howToPlay.enabled = false;
    }
}
