using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Advertisements;
using GoogleMobileAds.Api;

public class AdTracker : MonoBehaviour {

    private static AdTracker instanceRef;
    public int attemptCounter;
    public InterstitialAd interstitial;

    // Use this for initialization
    void Start () {

        //ACTUAL ID TO USE WHEN READY
        string appId = "ca-app-pub-8528536622826454~8644572820";

        //string appId = "ca-app-pub-3940256099942544~3347511713";
        MobileAds.Initialize(appId);

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

    //Update is called once per frame
    void Update()
    {
        if (attemptCounter >= 10)
        {
            attemptCounter = 0;
            RequestInterstitial();
            ShowInterstitial();
        }
    }

    public void RequestInterstitial()
    {
        //ACTUAL ID TO USE WHEN READY
        string adUnitId = "ca-app-pub-8528536622826454/5443694412";

        //string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
    }

    public void ShowInterstitial()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
}
