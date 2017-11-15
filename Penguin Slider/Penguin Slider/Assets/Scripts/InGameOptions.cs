using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameOptions : MonoBehaviour {

    public bool hints;
    public AudioSource[] allAudioSources;

    private static InGameOptions instanceRef;

    public Sprite[] soundImages;
    int soundCounter = 0;

    // Use this for initialization
    void Start()
    {
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

    public void DisableHints()
    {
        hints ^= true;
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

    }

    public void DisableAllSound(GameObject btn)
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

        for (int i = 0; i < allAudioSources.Length; i++)
        {
            allAudioSources[i].enabled ^= true;
        }
        GameObject.Find("GameHandler").GetComponent<SoundController>().audioMenuInteraction.Play();

        if (soundCounter == 0)
        {
            soundCounter = 1;
        }
        else
        {
            soundCounter = 0;
        }

        btn.GetComponent<Image>().sprite = soundImages[soundCounter];
    }
}
