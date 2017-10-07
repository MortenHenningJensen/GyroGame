using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTracker : MonoBehaviour
{
    [SerializeField]
    public int deathCounter;
    private static LevelTracker instanceRef;
    private Canvas gameEnd;
    public bool gameEnded;
    public static bool findOnce;
    public Vector3 startPos;
    public bool hasCheckPoint;

    public float totalTimer;

    [SerializeField]
    public List<GameObject> activatedPlates; //List of all plates that has been activated
                                             //Lav array som har en liste med strings (navne på plates), så find elementet med GameObject.Find(arraystring), ved ikke om det vil hjælpe, ellers få Skinke til at kigge på det
    [SerializeField]
    public string[] platesToAdd;

    void Awake()
    {
        deathCounter = 1;
        platesToAdd = new string[10];
        findOnce = false;
        hasCheckPoint = false;

        if (instanceRef == null)
        {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void Update()
    {
        if (!findOnce)
        {
            gameEnd = GameObject.Find("EndScreen").GetComponent<Canvas>();
            gameEnd.enabled = false;
            findOnce = true;
        }


        for (int i = 0; i < activatedPlates.Count; i++)
        {
            if (activatedPlates[i] != null)
            {
                platesToAdd[i] = activatedPlates[i].name;
            }
        }

    }

    public void AddDeath()
    {
        if (deathCounter % 3 == 0)
        {
           GameObject.Find("AdTracker").GetComponent<AdTracker>().attemptCounter++;
        }

        totalTimer += GameObject.Find("UI").GetComponent<UI>().timeLeft;

        deathCounter++;

        int attemptAdder = PlayerPrefs.GetInt("totalAttempts " + SceneManager.GetActiveScene().name) + deathCounter;

        PlayerPrefs.SetInt("totalAttempts " + SceneManager.GetActiveScene().name, attemptAdder);
    }

}
