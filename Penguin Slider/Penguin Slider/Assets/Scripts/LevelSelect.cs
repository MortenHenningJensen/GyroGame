using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    string levelToEnterName;

    [SerializeField]
    public List<GameObject> levels;

    public string firstLevelUnlocked;

    private GameObject[] levelstofind;

    private Canvas levelInfo;


    public void LevelSelected(string enterWorld)
    {
        if (PlayerPrefs.GetInt("lvl " + enterWorld) >= 1)
        {
            SceneManager.LoadScene(enterWorld);
        }

        if (PlayerPrefs.GetInt("Hidden " + enterWorld) >= 1)
        {
            SceneManager.LoadScene(enterWorld);
        }
    }

    public void PlayLevel()
    {
        if (PlayerPrefs.GetInt("lvl " + levelToEnterName) >= 1)
        {
            SceneManager.LoadScene(levelToEnterName);
        }

        if (PlayerPrefs.GetInt("Hidden " + levelToEnterName) >= 1)
        {
            SceneManager.LoadScene(levelToEnterName);
        }
    }

    void Start()
    {
        levelInfo = GameObject.Find("LevelHighlight").GetComponent<Canvas>();
        PlayerPrefs.SetInt(firstLevelUnlocked, 1);

        levels = new List<GameObject>();

        levelstofind = GameObject.FindGameObjectsWithTag("LevelSelecter");

        foreach (GameObject lvl in levelstofind)
        {
            levels.Add(lvl); //Adds every Plate in game to a list..
        }

        SetUP();
    }

    public void InfoCanvas(GameObject obj)
    {
        levelInfo.enabled = true;
        levelToEnterName = obj.GetComponentInChildren<Text>().text;
        levelInfo.GetComponentInChildren<Text>().text = PlayerPrefs.GetString(obj.GetComponentInChildren<Text>().text + "Title");

        Sprite newSprite = obj.GetComponent<Image>().sprite;
        levelInfo.transform.FindChild("Button").GetComponent<Image>().sprite = newSprite;

        levelInfo.transform.FindChild("YourBestTime").GetComponent<Text>().text = "Your best time: " + PlayerPrefs.GetFloat("bestTime " + obj.GetComponentInChildren<Text>().text).ToString("F2") + " Seconds";

        levelInfo.transform.FindChild("1StarTime").GetComponent<Text>().text = "1 Pebble: " + PlayerPrefs.GetFloat(obj.GetComponentInChildren<Text>().text + " Timer1").ToString("F0");
        levelInfo.transform.FindChild("2StarTime").GetComponent<Text>().text = "2 Pebbles: " + PlayerPrefs.GetFloat(obj.GetComponentInChildren<Text>().text + " Timer2").ToString("F0");
        levelInfo.transform.FindChild("3StarTime").GetComponent<Text>().text = "3 Pebbles: " + PlayerPrefs.GetFloat(obj.GetComponentInChildren<Text>().text + " Timer3").ToString("F0");

        levelInfo.transform.FindChild("BestAttempts").GetComponent<Text>().text = "Best Attempts: " + PlayerPrefs.GetInt("bestAttempts " + obj.GetComponentInChildren<Text>().text);
        levelInfo.transform.FindChild("TotalAttempts").GetComponent<Text>().text = "Total Attempts: " + PlayerPrefs.GetInt("totalAttempts " + obj.GetComponentInChildren<Text>().text);


        if (PlayerPrefs.GetInt("hasActivate " + obj.GetComponentInChildren<Text>().text) == 0)
        {
            Color a = levelInfo.transform.FindChild("PlateInfo").GetComponent<Image>().color;
            a.a = 0.2f;
            levelInfo.transform.FindChild("PlateInfo").GetComponent<Image>().color = a;
        }
        else
        {
            Color a = levelInfo.transform.FindChild("PlateInfo").GetComponent<Image>().color;
            a.a = 1f;
            levelInfo.transform.FindChild("PlateInfo").GetComponent<Image>().color = a;

        }

        if (PlayerPrefs.GetInt("hasJump " + obj.GetComponentInChildren<Text>().text) == 0)
        {
            Color b = levelInfo.transform.FindChild("JumpInfo").GetComponent<Image>().color;
            b.a = 0.2f;
            levelInfo.transform.FindChild("JumpInfo").GetComponent<Image>().color = b;
        }
        else
        {
            Color b = levelInfo.transform.FindChild("JumpInfo").GetComponent<Image>().color;
            b.a = 1f;
            levelInfo.transform.FindChild("JumpInfo").GetComponent<Image>().color = b;

        }

        if (PlayerPrefs.GetInt("hasNug " + obj.GetComponentInChildren<Text>().text) == 0)
        {
            Color c = levelInfo.transform.FindChild("NugLevel").GetComponent<Image>().color;
            c.a = 0.2f;
            levelInfo.transform.FindChild("NugLevel").GetComponent<Image>().color = c;
        }
        else
        {
            Color c = levelInfo.transform.FindChild("NugLevel").GetComponent<Image>().color;
            c.a = 1f;
            levelInfo.transform.FindChild("NugLevel").GetComponent<Image>().color = c;

        }
    }

    public void DisableInfoCanvas()
    {
        levelInfo.enabled = false;
    }

    public void AreYouSurePrompt(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void AreYouSurePromptNo(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void SetUP()
    {
        foreach (GameObject item in levels)
        {
            // Debug.Log(item.GetComponentInChildren<Text>().text + " " + PlayerPrefs.GetInt("lvl " + item.GetComponentInChildren<Text>().text));
            if (PlayerPrefs.GetInt("lvl " + item.transform.FindChild("Text").GetComponent<Text>().text) != 0)
            {
                // Debug.Log("TRUE");
                item.GetComponent<Button>().interactable = true;
            }
            else
            {
                // Debug.Log("FALSE");
                item.GetComponent<Button>().interactable = false;
                //item.IsInteractable();
            }
        }

        foreach (GameObject item in levels)
        {
            //Debug.Log(PlayerPrefs.GetInt("Level " + item.transform.FindChild("Text").GetComponent<Text>().text));
            ////Debug.Log(PlayerPrefs.GetInt("Level " + item.transform.FindChild("Text").GetComponent<Text>().text));
            //if (PlayerPrefs.GetInt("Level " + item.transform.FindChild("Text").GetComponent<Text>().text) >= 0)
            //{
            // item.transform.FindChild("StarsText").GetComponent<Text>().text = PlayerPrefs.GetInt("Level " + item.transform.FindChild("Text").GetComponent<Text>().text).ToString() + " / 3 Stars";
            switch (PlayerPrefs.GetInt("Level " + item.transform.FindChild("Text").GetComponent<Text>().text))
            {
                case 0:

                    Color c = item.transform.FindChild("StarOne").GetComponent<Image>().color;
                    c.a = 0.4f;
                    item.transform.FindChild("StarOne").GetComponent<Image>().color = c;

                    Color v = item.transform.FindChild("StarTwo").GetComponent<Image>().color;
                    v.a = 0.4f;
                    item.transform.FindChild("StarTwo").GetComponent<Image>().color = v;

                    Color b = item.transform.FindChild("StarThree").GetComponent<Image>().color;
                    b.a = 0.4f;
                    item.transform.FindChild("StarThree").GetComponent<Image>().color = b;

                    break;
                case 1:
                    Color n = item.transform.FindChild("StarOne").GetComponent<Image>().color;
                    n.a = 1f;
                    item.transform.FindChild("StarOne").GetComponent<Image>().color = n;
                    break;
                case 2:
                    Color m = item.transform.FindChild("StarOne").GetComponent<Image>().color;
                    m.a = 1f;
                    item.transform.FindChild("StarOne").GetComponent<Image>().color = m;

                    Color a = item.transform.FindChild("StarTwo").GetComponent<Image>().color;
                    a.a = 1f;
                    item.transform.FindChild("StarTwo").GetComponent<Image>().color = a;

                    break;
                case 3:
                    Color s = item.transform.FindChild("StarOne").GetComponent<Image>().color;
                    s.a = 1f;
                    item.transform.FindChild("StarOne").GetComponent<Image>().color = s;

                    Color d = item.transform.FindChild("StarTwo").GetComponent<Image>().color;
                    d.a = 1f;
                    item.transform.FindChild("StarTwo").GetComponent<Image>().color = d;

                    Color f = item.transform.FindChild("StarThree").GetComponent<Image>().color;
                    f.a = 1f;
                    item.transform.FindChild("StarThree").GetComponent<Image>().color = f;

                    break;
                default:
                    break;
            }
            //}
        }

        GameObject[] hidden = GameObject.FindGameObjectsWithTag("LevelHidden");
        foreach (GameObject hiddenobj in hidden)
        {
           // Debug.Log(hiddenobj.transform.FindChild("Text").GetComponent<Text>().text);
            if (PlayerPrefs.GetInt("Hidden " + hiddenobj.transform.FindChild("Text").GetComponent<Text>().text) == 1)
            {
                hiddenobj.SetActive(true);

                switch (PlayerPrefs.GetInt("Level " + hiddenobj.transform.FindChild("Text").GetComponent<Text>().text))
                {
                    case 0:

                        Color c = hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color;
                        c.a = 0.4f;
                        hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color = c;

                        Color v = hiddenobj.transform.FindChild("StarTwo").GetComponent<Image>().color;
                        v.a = 0.4f;
                        hiddenobj.transform.FindChild("StarTwo").GetComponent<Image>().color = v;

                        Color b = hiddenobj.transform.FindChild("StarThree").GetComponent<Image>().color;
                        b.a = 0.4f;
                        hiddenobj.transform.FindChild("StarThree").GetComponent<Image>().color = b;

                        break;
                    case 1:
                        Color n = hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color;
                        n.a = 1f;
                        hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color = n;
                        break;
                    case 2:
                        Color m = hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color;
                        m.a = 1f;
                        hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color = m;

                        Color a = hiddenobj.transform.FindChild("StarTwo").GetComponent<Image>().color;
                        a.a = 1f;
                        hiddenobj.transform.FindChild("StarTwo").GetComponent<Image>().color = a;

                        break;
                    case 3:
                        Color s = hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color;
                        s.a = 1f;
                        hiddenobj.transform.FindChild("StarOne").GetComponent<Image>().color = s;

                        Color d = hiddenobj.transform.FindChild("StarTwo").GetComponent<Image>().color;
                        d.a = 1f;
                        hiddenobj.transform.FindChild("StarTwo").GetComponent<Image>().color = d;

                        Color f = hiddenobj.transform.FindChild("StarThree").GetComponent<Image>().color;
                        f.a = 1f;
                        hiddenobj.transform.FindChild("StarThree").GetComponent<Image>().color = f;

                        break;
                    default:
                        break;
                }

               // hiddenobj.transform.FindChild("StarsText").GetComponent<Text>().text = PlayerPrefs.GetInt("Level " + hiddenobj.transform.FindChild("Text").GetComponent<Text>().text).ToString() + " / 3 Stars";

            }
            else
            {
                hiddenobj.SetActive(false);
            }

        }

    }

    public void ResetData(GameObject obj)
    {
        PlayerPrefs.DeleteAll();
        obj.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
