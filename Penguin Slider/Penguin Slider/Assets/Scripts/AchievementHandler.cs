using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementHandler : MonoBehaviour {

    public void ThreePebbleProgress()
    {
        PlayGamesScript.IncrementalUnlockAchievement(GPGSIds.achievement_pebble_collector, 1);
    }

    public void IceMasterDone()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_ice_master);
    }

    public void SandMasterDone()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_sand_master);
    }

    public void SecretDone()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_secret_level);
    }
}
