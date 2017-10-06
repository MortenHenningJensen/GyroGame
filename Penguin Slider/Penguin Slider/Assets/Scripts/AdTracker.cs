using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdTracker : MonoBehaviour {

    private static AdTracker instanceRef;
    public int attemptCounter;

    // Use this for initialization
    void Start () {

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

    // Update is called once per frame
    void Update () {

        if (attemptCounter >= 5)
        {
            attemptCounter = 0;
            Advertisement.Show();
            
        }
	}
}
