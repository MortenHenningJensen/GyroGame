using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;

public class PlayGamesScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        SignIn();
        Debug.Log("LOGIN SUCCESS!");
    }

    void SignIn()
    {
        Social.localUser.Authenticate(success => { });
    }

    #region Achivements
    public static void UnlockAchievement(string id)
    {
        //Will unlock an achievement completely
        Social.ReportProgress(id, 100, success => { });
    }

    public static void IncrementalUnlockAchievement(string id, int stepsToIncrement)
    {
        //will unlock the incremental part of an achievment (so maybe 1 of 100 steps), or 1 of 36
        PlayGamesPlatform.Instance.IncrementAchievement(id, stepsToIncrement, success => { });
    }

    public void ShowAchievementUI()
    {
        Debug.Log("Opening Achi UI");
        Social.ShowAchievementsUI();
    }
    #endregion
}
