using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{

    public float timeLeft;
    string timeDisp;
    bool gameOver;
    public Text _txtTimer;
    private LevelTracker lt;
    public Canvas pauseMenu;
    private bool firstAttempt;
    public bool hintBox;
    public string hintText;
    public GameObject hint;
    public Text hintTextBox;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        timeLeft = GameObject.Find("GameTracker").GetComponent<LevelTracker>().totalTimer;
        lt = GameObject.Find("GameTracker").GetComponent<LevelTracker>();

        if (PlayerPrefs.GetFloat("bestTime " + SceneManager.GetActiveScene().name) > 0)
        {
            GameObject.Find("HighScoreTimer").GetComponent<Text>().text = PlayerPrefs.GetFloat("bestTime " + SceneManager.GetActiveScene().name).ToString("F2");
            firstAttempt = false;
        }
        else
        {
            firstAttempt = true;
        }

        if (!lt.hasShowedHint)
        {
            if (hintBox)
            {
                hint.SetActive(true);
                lt.gameEnded = true;
                hintTextBox.text = hintText;
            }
            else
            {
                hint.SetActive(false);
            }

            lt.hasShowedHint = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!lt.gameEnded)
        {
            timeDisp = timeLeft.ToString();
            if (gameOver == false)
            {
                timeLeft += Time.deltaTime;
            }

            GameObject.Find("Deaths").GetComponent<Text>().text = lt.deathCounter.ToString();
        }
    }

    public void CloseHint()
    {
        hint.SetActive(false);
        lt.gameEnded = false;
    }

    void GameOver()
    {
        gameOver = true;
        lt.AddDeath();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnGUI()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60F);
        int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
        string timeDisp = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (timeLeft < PlayerPrefs.GetFloat("bestTime " + SceneManager.GetActiveScene().name) || firstAttempt)
        {
            _txtTimer.color = Color.green;
        }
        else
        {
            _txtTimer.color = Color.red;
        }
        _txtTimer.text = timeDisp;

        if (firstAttempt)
        {
            GameObject.Find("HighScoreTimer").GetComponent<Text>().text = timeDisp;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.enabled = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.enabled = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
