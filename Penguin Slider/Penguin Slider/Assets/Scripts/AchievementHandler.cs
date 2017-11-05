using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementHandler : MonoBehaviour {

    //GIVEN WHEN PLAYER COLLECTS GOLDEN NUGGET
    public void UnlockFirstHidden()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_complete_a_hidden_level);
    }

    //GIVEN WHEN A PLAYER COMPLETES A LEVEL TO A 3 STAR RATING
    public void ThreePebbleProgress()
    {
        PlayGamesScript.IncrementalUnlockAchievement(GPGSIds.achievement_pebble_collector, 1);
    }

    //GIVEN WHEN PLAYER COMPLETES ALL ICE LEVELS
    public void IceMasterDone()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_ice_master);
    }

    //GIVEN WHEN PLAYER COMPLETES ALL SAND LEVELS
    public void SandMasterDone()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_sand_master);
    }

    //GIVEN WHEN PLAYER COMPLETED ALL SECRET LEVELS
    public void NoSecret()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_no_secrets_here);
    }

    //GIVEN WHEN PLAYER HAS X+ ATTEMPTS ON A LEVEL
    public void NotFair()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_this_is_not_fair);
    }

    //GIVEN WHEN PLAYER COMPLETES A SECRET LEVEL
    public void SecretDone()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_secret_level);
    }
}
