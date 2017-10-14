using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameOptions : MonoBehaviour {

    public bool hints;
    public AudioSource[] allAudioSources;

    private static InGameOptions instanceRef;

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
    }

    public void DisableAllSound()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

        for (int i = 0; i < allAudioSources.Length; i++)
        {
            allAudioSources[i].enabled ^= true;
        }

    }
}
