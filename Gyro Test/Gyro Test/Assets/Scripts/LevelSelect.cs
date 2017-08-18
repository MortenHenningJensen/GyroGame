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

    private GameObject[] levelstofind; //Finds all Gameobjects with tag "Plate"


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

    void Start()
    {
        PlayerPrefs.SetInt(firstLevelUnlocked, 1);

        levels = new List<GameObject>();

        levelstofind = GameObject.FindGameObjectsWithTag("LevelSelecter");

        foreach (GameObject lvl in levelstofind)
        {
            levels.Add(lvl); //Adds every Plate in game to a list..
        }

        SetUP();
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
            Debug.Log(PlayerPrefs.GetInt("Level " + item.transform.FindChild("Text").GetComponent<Text>().text));
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
            Debug.Log(hiddenobj.transform.FindChild("Text").GetComponent<Text>().text);
            if (PlayerPrefs.GetInt("Hidden " + hiddenobj.transform.FindChild("Text").GetComponent<Text>().text) == 1)
            {
                hiddenobj.SetActive(true);
                hiddenobj.transform.FindChild("StarsText").GetComponent<Text>().text = PlayerPrefs.GetInt("Level " + hiddenobj.transform.FindChild("Text").GetComponent<Text>().text).ToString() + " / 3 Stars";

            }
            else
            {
                hiddenobj.SetActive(false);
            }
        }

    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
