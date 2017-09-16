using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInformation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        WorldOneStats();
        WorldTwoStats();
        WorldThreeStats();
        WorldFourStats();
        WorldFiveStats();
        WorldSixStats();
        WorldSevenStats();
        WorldEightStats();

        if (PlayerPrefs.GetInt("RunOnce") == 0)
        {
            SetTimers();
            SetAttempts();
        }
	}
	
    private void WorldOneStats()
    {
        PlayerPrefs.SetString("1-1Title", "Introduction");
        PlayerPrefs.SetString("1-1 Timer1", "00:20");
        PlayerPrefs.SetString("1-1 Timer2", "00:15");
        PlayerPrefs.SetString("1-1 Timer3", "00:10");
        PlayerPrefs.SetInt("hasActivate 1-1", 0);
        PlayerPrefs.SetInt("hasJump 1-1", 0);
        PlayerPrefs.SetInt("hasNug 1-1", 0);

        PlayerPrefs.SetString("1-2Title", "Introduction");
        PlayerPrefs.SetString("1-2 Timer1", "00:20");
        PlayerPrefs.SetString("1-2 Timer2", "00:15");
        PlayerPrefs.SetString("1-2 Timer3", "00:10");
        PlayerPrefs.SetInt("hasActivate 1-2", 1);
        PlayerPrefs.SetInt("hasJump 1-2", 0);
        PlayerPrefs.SetInt("hasNug 1-2", 0);

        PlayerPrefs.SetString("1-3Title", "Introduction");
        PlayerPrefs.SetString("1-3 Timer1", "00:10");
        PlayerPrefs.SetString("1-3 Timer2", "00:20");
        PlayerPrefs.SetString("1-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-3", 1);
        PlayerPrefs.SetInt("hasJump 1-3", 0);
        PlayerPrefs.SetInt("hasNug 1-3", 0);

        PlayerPrefs.SetString("1-4Title", "Introduction");
        PlayerPrefs.SetString("1-4 Timer1", "00:10");
        PlayerPrefs.SetString("1-4 Timer2", "00:20");
        PlayerPrefs.SetString("1-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-4", 1);
        PlayerPrefs.SetInt("hasJump 1-4", 0);
        PlayerPrefs.SetInt("hasNug 1-4", 0);

        PlayerPrefs.SetString("1-5Title", "Introduction");
        PlayerPrefs.SetString("1-5 Timer1", "00:10");
        PlayerPrefs.SetString("1-5 Timer2", "00:20");
        PlayerPrefs.SetString("1-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-5", 1);
        PlayerPrefs.SetInt("hasJump 1-5", 0);
        PlayerPrefs.SetInt("hasNug 1-5", 0);

        PlayerPrefs.SetString("1-6Title", "Introduction");
        PlayerPrefs.SetString("1-6 Timer1", "00:10");
        PlayerPrefs.SetString("1-6 Timer2", "00:20");
        PlayerPrefs.SetString("1-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-6", 1);
        PlayerPrefs.SetInt("hasJump 1-6", 0);
        PlayerPrefs.SetInt("hasNug 1-6", 1);

        PlayerPrefs.SetString("1-7Title", "Introduction");
        PlayerPrefs.SetString("1-7 Timer1", "00:10");
        PlayerPrefs.SetString("1-7 Timer2", "00:20");
        PlayerPrefs.SetString("1-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-7", 1);
        PlayerPrefs.SetInt("hasJump 1-7", 0);
        PlayerPrefs.SetInt("hasNug 1-7", 0);
  
        PlayerPrefs.SetString("1-8Title", "Introduction");
        PlayerPrefs.SetString("1-8 Timer1", "00:10");
        PlayerPrefs.SetString("1-8 Timer2", "00:20");
        PlayerPrefs.SetString("1-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-8", 1);
        PlayerPrefs.SetInt("hasJump 1-8", 0);
        PlayerPrefs.SetInt("hasNug 1-8", 0);

        PlayerPrefs.SetString("1-9Title", "Introduction");
        PlayerPrefs.SetString("1-9 Timer1", "00:10");
        PlayerPrefs.SetString("1-9 Timer2", "00:20");
        PlayerPrefs.SetString("1-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-9", 1);
        PlayerPrefs.SetInt("hasJump 1-9", 0);
        PlayerPrefs.SetInt("hasNug 1-9", 0);

        PlayerPrefs.SetString("1-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("1-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("1-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("1-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 1-Hidden", 1);
        PlayerPrefs.SetInt("hasNug 1-Hidden", 0);
    }

    private void WorldTwoStats()
    {
        PlayerPrefs.SetString("2-1Title", "Introduction");
        PlayerPrefs.SetString("2-1 Timer1", "00:10");
        PlayerPrefs.SetString("2-1 Timer2", "00:20");
        PlayerPrefs.SetString("2-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-1", 0);
        PlayerPrefs.SetInt("hasJump 2-1", 1);
        PlayerPrefs.SetInt("hasNug 2-1", 0);

        PlayerPrefs.SetString("2-2Title", "Introduction");
        PlayerPrefs.SetString("2-2 Timer1", "00:10");
        PlayerPrefs.SetString("2-2 Timer2", "00:20");
        PlayerPrefs.SetString("2-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-2", 0);
        PlayerPrefs.SetInt("hasJump 2-2", 0);
        PlayerPrefs.SetInt("hasNug 2-2", 0);

        PlayerPrefs.SetString("2-3Title", "Introduction");
        PlayerPrefs.SetString("2-3 Timer1", "00:10");
        PlayerPrefs.SetString("2-3 Timer2", "00:20");
        PlayerPrefs.SetString("2-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-3", 0);
        PlayerPrefs.SetInt("hasJump 2-3", 1);
        PlayerPrefs.SetInt("hasNug 2-3", 0);

        PlayerPrefs.SetString("2-4Title", "Introduction");
        PlayerPrefs.SetString("2-4 Timer1", "00:10");
        PlayerPrefs.SetString("2-4 Timer2", "00:20");
        PlayerPrefs.SetString("2-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-4", 0);
        PlayerPrefs.SetInt("hasJump 2-4", 0);
        PlayerPrefs.SetInt("hasNug 2-4", 0);

        PlayerPrefs.SetString("2-5Title", "Introduction");
        PlayerPrefs.SetString("2-5 Timer1", "00:10");
        PlayerPrefs.SetString("2-5 Timer2", "00:20");
        PlayerPrefs.SetString("2-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-5", 0);
        PlayerPrefs.SetInt("hasJump 2-5", 1);
        PlayerPrefs.SetInt("hasNug 2-5", 0);

        PlayerPrefs.SetString("2-6Title", "Introduction");
        PlayerPrefs.SetString("2-6 Timer1", "00:10");
        PlayerPrefs.SetString("2-6 Timer2", "00:20");
        PlayerPrefs.SetString("2-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-6", 0);
        PlayerPrefs.SetInt("hasJump 2-6", 1);
        PlayerPrefs.SetInt("hasNug 2-6", 0);

        PlayerPrefs.SetString("2-7Title", "Introduction");
        PlayerPrefs.SetString("2-7 Timer1", "00:10");
        PlayerPrefs.SetString("2-7 Timer2", "00:20");
        PlayerPrefs.SetString("2-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-7", 0);
        PlayerPrefs.SetInt("hasJump 2-7", 1);
        PlayerPrefs.SetInt("hasNug 2-7", 0);

        PlayerPrefs.SetString("2-8Title", "Introduction");
        PlayerPrefs.SetString("2-8 Timer1", "00:10");
        PlayerPrefs.SetString("2-8 Timer2", "00:20");
        PlayerPrefs.SetString("2-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-8", 0);
        PlayerPrefs.SetInt("hasJump 2-8", 0);
        PlayerPrefs.SetInt("hasNug 2-8", 0);

        PlayerPrefs.SetString("2-9Title", "Introduction");
        PlayerPrefs.SetString("2-9 Timer1", "00:10");
        PlayerPrefs.SetString("2-9 Timer2", "00:20");
        PlayerPrefs.SetString("2-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-9", 0);
        PlayerPrefs.SetInt("hasJump 2-9", 0);
        PlayerPrefs.SetInt("hasNug 2-9", 1);

        PlayerPrefs.SetString("2-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("2-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("2-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("2-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 2-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 2-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 2-Hidden", 0);

    }

    private void WorldThreeStats()
    {
        PlayerPrefs.SetString("3-1Title", "Introduction");
        PlayerPrefs.SetString("3-1 Timer1", "00:10");
        PlayerPrefs.SetString("3-1 Timer2", "00:20");
        PlayerPrefs.SetString("3-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-1", 0);
        PlayerPrefs.SetInt("hasJump 3-1", 0);
        PlayerPrefs.SetInt("hasNug 3-1", 0);

        PlayerPrefs.SetString("3-2Title", "Introduction");
        PlayerPrefs.SetString("3-2 Timer1", "00:10");
        PlayerPrefs.SetString("3-2 Timer2", "00:20");
        PlayerPrefs.SetString("3-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-2", 0);
        PlayerPrefs.SetInt("hasJump 3-2", 0);
        PlayerPrefs.SetInt("hasNug 3-2", 0);

        PlayerPrefs.SetString("3-3Title", "Introduction");
        PlayerPrefs.SetString("3-3 Timer1", "00:10");
        PlayerPrefs.SetString("3-3 Timer2", "00:20");
        PlayerPrefs.SetString("3-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-3", 0);
        PlayerPrefs.SetInt("hasJump 3-3", 0);
        PlayerPrefs.SetInt("hasNug 3-3", 0);

        PlayerPrefs.SetString("3-4Title", "Introduction");
        PlayerPrefs.SetString("3-4 Timer1", "00:10");
        PlayerPrefs.SetString("3-4 Timer2", "00:20");
        PlayerPrefs.SetString("3-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-4", 0);
        PlayerPrefs.SetInt("hasJump 3-4", 0);
        PlayerPrefs.SetInt("hasNug 3-4", 0);

        PlayerPrefs.SetString("3-5Title", "Introduction");
        PlayerPrefs.SetString("3-5 Timer1", "00:10");
        PlayerPrefs.SetString("3-5 Timer2", "00:20");
        PlayerPrefs.SetString("3-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-5", 1);
        PlayerPrefs.SetInt("hasJump 3-5", 1);
        PlayerPrefs.SetInt("hasNug 3-5", 0);

        PlayerPrefs.SetString("3-6Title", "Introduction");
        PlayerPrefs.SetString("3-6 Timer1", "00:10");
        PlayerPrefs.SetString("3-6 Timer2", "00:20");
        PlayerPrefs.SetString("3-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-6", 0);
        PlayerPrefs.SetInt("hasJump 3-6", 0);
        PlayerPrefs.SetInt("hasNug 3-6", 0);

        PlayerPrefs.SetString("3-7Title", "Introduction");
        PlayerPrefs.SetString("3-7 Timer1", "00:10");
        PlayerPrefs.SetString("3-7 Timer2", "00:20");
        PlayerPrefs.SetString("3-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-7", 1);
        PlayerPrefs.SetInt("hasJump 3-7", 1);
        PlayerPrefs.SetInt("hasNug 3-7", 1);

        PlayerPrefs.SetString("3-8Title", "Introduction");
        PlayerPrefs.SetString("3-8 Timer1", "00:10");
        PlayerPrefs.SetString("3-8 Timer2", "00:20");
        PlayerPrefs.SetString("3-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-8", 0);
        PlayerPrefs.SetInt("hasJump 3-8", 0);
        PlayerPrefs.SetInt("hasNug 3-8", 0);

        PlayerPrefs.SetString("3-9Title", "Introduction");
        PlayerPrefs.SetString("3-9 Timer1", "00:10");
        PlayerPrefs.SetString("3-9 Timer2", "00:20");
        PlayerPrefs.SetString("3-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 3-9", 1);
        PlayerPrefs.SetInt("hasJump 3-9", 1);
        PlayerPrefs.SetInt("hasNug 3-9", 0);

        PlayerPrefs.SetString("3-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("3-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("3-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("3-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 1-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 3-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 3-Hidden", 0);

    }

    private void WorldFourStats()
    {
        PlayerPrefs.SetString("4-1Title", "Introduction");
        PlayerPrefs.SetString("4-1 Timer1", "00:10");
        PlayerPrefs.SetString("4-1 Timer2", "00:20");
        PlayerPrefs.SetString("4-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-1", 1);
        PlayerPrefs.SetInt("hasJump 4-1", 0);
        PlayerPrefs.SetInt("hasNug 4-1", 1);

        PlayerPrefs.SetString("4-2Title", "Introduction");
        PlayerPrefs.SetString("4-2 Timer1", "00:10");
        PlayerPrefs.SetString("4-2 Timer2", "00:20");
        PlayerPrefs.SetString("4-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-2", 0);
        PlayerPrefs.SetInt("hasJump 4-2", 0);
        PlayerPrefs.SetInt("hasNug 4-2", 0);

        PlayerPrefs.SetString("4-3Title", "Introduction");
        PlayerPrefs.SetString("4-3 Timer1", "00:10");
        PlayerPrefs.SetString("4-3 Timer2", "00:20");
        PlayerPrefs.SetString("4-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-3", 0);
        PlayerPrefs.SetInt("hasJump 4-3", 0);
        PlayerPrefs.SetInt("hasNug 4-3", 0);

        PlayerPrefs.SetString("4-4Title", "Introduction");
        PlayerPrefs.SetString("4-4 Timer1", "00:10");
        PlayerPrefs.SetString("4-4 Timer2", "00:20");
        PlayerPrefs.SetString("4-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-4", 0);
        PlayerPrefs.SetInt("hasJump 4-4", 0);
        PlayerPrefs.SetInt("hasNug 4-4", 0);

        PlayerPrefs.SetString("4-5Title", "Introduction");
        PlayerPrefs.SetString("4-5 Timer1", "00:10");
        PlayerPrefs.SetString("4-5 Timer2", "00:20");
        PlayerPrefs.SetString("4-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-5", 0);
        PlayerPrefs.SetInt("hasJump 4-5", 0);
        PlayerPrefs.SetInt("hasNug 4-5", 0);

        PlayerPrefs.SetString("4-6Title", "Introduction");
        PlayerPrefs.SetString("4-6 Timer1", "00:10");
        PlayerPrefs.SetString("4-6 Timer2", "00:20");
        PlayerPrefs.SetString("4-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-6", 0);
        PlayerPrefs.SetInt("hasJump 4-6", 0);
        PlayerPrefs.SetInt("hasNug 4-6", 0);

        PlayerPrefs.SetString("4-7Title", "Introduction");
        PlayerPrefs.SetString("4-7 Timer1", "00:10");
        PlayerPrefs.SetString("4-7 Timer2", "00:20");
        PlayerPrefs.SetString("4-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-7", 0);
        PlayerPrefs.SetInt("hasJump 4-7", 1);
        PlayerPrefs.SetInt("hasNug 4-7", 0);

        PlayerPrefs.SetString("4-8Title", "Introduction");
        PlayerPrefs.SetString("4-8 Timer1", "00:10");
        PlayerPrefs.SetString("4-8 Timer2", "00:20");
        PlayerPrefs.SetString("4-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-8", 0);
        PlayerPrefs.SetInt("hasJump 4-8", 0);
        PlayerPrefs.SetInt("hasNug 4-8", 0);

        PlayerPrefs.SetString("4-9Title", "Introduction");
        PlayerPrefs.SetString("4-9 Timer1", "00:10");
        PlayerPrefs.SetString("4-9 Timer2", "00:20");
        PlayerPrefs.SetString("4-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-9", 0);
        PlayerPrefs.SetInt("hasJump 4-9", 1);
        PlayerPrefs.SetInt("hasNug 4-9", 0);

        PlayerPrefs.SetString("4-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("4-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("4-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("4-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 4-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 4-Hidden", 1);
        PlayerPrefs.SetInt("hasNug 4-Hidden", 0);

    }

    private void WorldFiveStats()
    {
        PlayerPrefs.SetString("5-1Title", "Introduction");
        PlayerPrefs.SetString("5-1 Timer1", "00:10");
        PlayerPrefs.SetString("5-1 Timer2", "00:20");
        PlayerPrefs.SetString("5-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-1", 1);
        PlayerPrefs.SetInt("hasJump 5-1", 0);
        PlayerPrefs.SetInt("hasNug 5-1", 0);

        PlayerPrefs.SetString("5-2Title", "Introduction");
        PlayerPrefs.SetString("5-2 Timer1", "00:10");
        PlayerPrefs.SetString("5-2 Timer2", "00:20");
        PlayerPrefs.SetString("5-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-2", 1);
        PlayerPrefs.SetInt("hasJump 5-2", 0);
        PlayerPrefs.SetInt("hasNug 5-2", 0);

        PlayerPrefs.SetString("5-3Title", "Introduction");
        PlayerPrefs.SetString("5-3 Timer1", "00:10");
        PlayerPrefs.SetString("5-3 Timer2", "00:20");
        PlayerPrefs.SetString("5-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-3", 0);
        PlayerPrefs.SetInt("hasJump 5-3", 0);
        PlayerPrefs.SetInt("hasNug 5-3", 0);

        PlayerPrefs.SetString("5-4Title", "Introduction");
        PlayerPrefs.SetString("5-4 Timer1", "00:10");
        PlayerPrefs.SetString("5-4 Timer2", "00:20");
        PlayerPrefs.SetString("5-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-4", 0);
        PlayerPrefs.SetInt("hasJump 5-4", 0);
        PlayerPrefs.SetInt("hasNug 5-4", 0);

        PlayerPrefs.SetString("5-5Title", "Introduction");
        PlayerPrefs.SetString("5-5 Timer1", "00:10");
        PlayerPrefs.SetString("5-5 Timer2", "00:20");
        PlayerPrefs.SetString("5-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-5", 1);
        PlayerPrefs.SetInt("hasJump 5-5", 0);
        PlayerPrefs.SetInt("hasNug 5-5", 0);

        PlayerPrefs.SetString("5-6Title", "Introduction");
        PlayerPrefs.SetString("5-6 Timer1", "00:10");
        PlayerPrefs.SetString("5-6 Timer2", "00:20");
        PlayerPrefs.SetString("5-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-6", 0);
        PlayerPrefs.SetInt("hasJump 5-6", 0);
        PlayerPrefs.SetInt("hasNug 5-6", 0);

        PlayerPrefs.SetString("5-7Title", "Introduction");
        PlayerPrefs.SetString("5-7 Timer1", "00:10");
        PlayerPrefs.SetString("5-7 Timer2", "00:20");
        PlayerPrefs.SetString("5-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-7", 1);
        PlayerPrefs.SetInt("hasJump 5-7", 0);
        PlayerPrefs.SetInt("hasNug 5-7", 0);

        PlayerPrefs.SetString("5-8Title", "Introduction");
        PlayerPrefs.SetString("5-8 Timer1", "00:10");
        PlayerPrefs.SetString("5-8 Timer2", "00:20");
        PlayerPrefs.SetString("5-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-8", 0);
        PlayerPrefs.SetInt("hasJump 5-8", 0);
        PlayerPrefs.SetInt("hasNug 5-8", 1);

        PlayerPrefs.SetString("5-9Title", "Introduction");
        PlayerPrefs.SetString("5-9 Timer1", "00:10");
        PlayerPrefs.SetString("5-9 Timer2", "00:20");
        PlayerPrefs.SetString("5-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-9", 0);
        PlayerPrefs.SetInt("hasJump 5-9", 1);
        PlayerPrefs.SetInt("hasNug 5-9", 0);

        PlayerPrefs.SetString("5-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("5-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("5-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("5-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 5-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 5-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 5-Hidden", 0);

    }

    private void WorldSixStats()
    {
        PlayerPrefs.SetString("6-1Title", "Introduction");
        PlayerPrefs.SetString("6-1 Timer1", "00:10");
        PlayerPrefs.SetString("6-1 Timer2", "00:20");
        PlayerPrefs.SetString("6-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-1", 0);
        PlayerPrefs.SetInt("hasJump 6-1", 0);
        PlayerPrefs.SetInt("hasNug 6-1", 0);

        PlayerPrefs.SetString("6-2Title", "Introduction");
        PlayerPrefs.SetString("6-2 Timer1", "00:10");
        PlayerPrefs.SetString("6-2 Timer2", "00:20");
        PlayerPrefs.SetString("6-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-2", 1);
        PlayerPrefs.SetInt("hasJump 6-2", 0);
        PlayerPrefs.SetInt("hasNug 6-2", 0);

        PlayerPrefs.SetString("6-3Title", "Introduction");
        PlayerPrefs.SetString("6-3 Timer1", "00:10");
        PlayerPrefs.SetString("6-3 Timer2", "00:20");
        PlayerPrefs.SetString("6-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-3", 1);
        PlayerPrefs.SetInt("hasJump 6-3", 0);
        PlayerPrefs.SetInt("hasNug 6-3", 0);

        PlayerPrefs.SetString("6-4Title", "Introduction");
        PlayerPrefs.SetString("6-4 Timer1", "00:10");
        PlayerPrefs.SetString("6-4 Timer2", "00:20");
        PlayerPrefs.SetString("6-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-4", 0);
        PlayerPrefs.SetInt("hasJump 6-4", 0);
        PlayerPrefs.SetInt("hasNug 6-4", 0);

        PlayerPrefs.SetString("6-5Title", "Introduction");
        PlayerPrefs.SetString("6-5 Timer1", "00:10");
        PlayerPrefs.SetString("6-5 Timer2", "00:20");
        PlayerPrefs.SetString("6-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-5", 0);
        PlayerPrefs.SetInt("hasJump 6-5", 0);
        PlayerPrefs.SetInt("hasNug 6-5", 0);

        PlayerPrefs.SetString("6-6Title", "Introduction");
        PlayerPrefs.SetString("6-6 Timer1", "00:10");
        PlayerPrefs.SetString("6-6 Timer2", "00:20");
        PlayerPrefs.SetString("6-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-6", 0);
        PlayerPrefs.SetInt("hasJump 6-6", 1);
        PlayerPrefs.SetInt("hasNug 6-6", 0);

        PlayerPrefs.SetString("6-7Title", "Introduction");
        PlayerPrefs.SetString("6-7 Timer1", "00:10");
        PlayerPrefs.SetString("6-7 Timer2", "00:20");
        PlayerPrefs.SetString("6-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-7", 1);
        PlayerPrefs.SetInt("hasJump 6-7", 0);
        PlayerPrefs.SetInt("hasNug 6-7", 0);

        PlayerPrefs.SetString("6-8Title", "Introduction");
        PlayerPrefs.SetString("6-8 Timer1", "00:10");
        PlayerPrefs.SetString("6-8 Timer2", "00:20");
        PlayerPrefs.SetString("6-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-8", 0);
        PlayerPrefs.SetInt("hasJump 6-8", 0);
        PlayerPrefs.SetInt("hasNug 6-8", 1);

        PlayerPrefs.SetString("6-9Title", "Introduction");
        PlayerPrefs.SetString("6-9 Timer1", "00:10");
        PlayerPrefs.SetString("6-9 Timer2", "00:20");
        PlayerPrefs.SetString("6-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-9", 1);
        PlayerPrefs.SetInt("hasJump 6-9", 0);
        PlayerPrefs.SetInt("hasNug 6-9", 0);

        PlayerPrefs.SetString("6-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("6-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("6-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("6-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 6-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 6-Hidden", 1);
        PlayerPrefs.SetInt("hasNug 6-Hidden", 0);

    }

    private void WorldSevenStats()
    {
        PlayerPrefs.SetString("7-1Title", "Introduction");
        PlayerPrefs.SetString("7-1 Timer1", "00:10");
        PlayerPrefs.SetString("7-1 Timer2", "00:20");
        PlayerPrefs.SetString("7-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-1", 0);
        PlayerPrefs.SetInt("hasJump 7-1", 0);
        PlayerPrefs.SetInt("hasNug 7-1", 0);

        PlayerPrefs.SetString("7-2Title", "Introduction");
        PlayerPrefs.SetString("7-2 Timer1", "00:10");
        PlayerPrefs.SetString("7-2 Timer2", "00:20");
        PlayerPrefs.SetString("7-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-2", 0);
        PlayerPrefs.SetInt("hasJump 7-2", 0);
        PlayerPrefs.SetInt("hasNug 7-2", 0);

        PlayerPrefs.SetString("7-3Title", "Introduction");
        PlayerPrefs.SetString("7-3 Timer1", "00:10");
        PlayerPrefs.SetString("7-3 Timer2", "00:20");
        PlayerPrefs.SetString("7-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-3", 0);
        PlayerPrefs.SetInt("hasJump 7-3", 1);
        PlayerPrefs.SetInt("hasNug 7-3", 0);

        PlayerPrefs.SetString("7-4Title", "Introduction");
        PlayerPrefs.SetString("7-4 Timer1", "00:10");
        PlayerPrefs.SetString("7-4 Timer2", "00:20");
        PlayerPrefs.SetString("7-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-4", 0);
        PlayerPrefs.SetInt("hasJump 7-4", 0);
        PlayerPrefs.SetInt("hasNug 7-4", 0);

        PlayerPrefs.SetString("7-5Title", "Introduction");
        PlayerPrefs.SetString("7-5 Timer1", "00:10");
        PlayerPrefs.SetString("7-5 Timer2", "00:20");
        PlayerPrefs.SetString("7-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-5", 0);
        PlayerPrefs.SetInt("hasJump 7-5", 1);
        PlayerPrefs.SetInt("hasNug 7-5", 0);

        PlayerPrefs.SetString("7-6Title", "Introduction");
        PlayerPrefs.SetString("7-6 Timer1", "00:10");
        PlayerPrefs.SetString("7-6 Timer2", "00:20");
        PlayerPrefs.SetString("7-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-6", 1);
        PlayerPrefs.SetInt("hasJump 7-6", 1);
        PlayerPrefs.SetInt("hasNug 7-6", 0);

        PlayerPrefs.SetString("7-7Title", "Introduction");
        PlayerPrefs.SetString("7-7 Timer1", "00:10");
        PlayerPrefs.SetString("7-7 Timer2", "00:20");
        PlayerPrefs.SetString("7-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-7", 0);
        PlayerPrefs.SetInt("hasJump 7-7", 0);
        PlayerPrefs.SetInt("hasNug 7-7", 1);

        PlayerPrefs.SetString("7-8Title", "Introduction");
        PlayerPrefs.SetString("7-8 Timer1", "00:10");
        PlayerPrefs.SetString("7-8 Timer2", "00:20");
        PlayerPrefs.SetString("7-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-8", 0);
        PlayerPrefs.SetInt("hasJump 7-8", 0);
        PlayerPrefs.SetInt("hasNug 7-8", 0);

        PlayerPrefs.SetString("7-9Title", "Introduction");
        PlayerPrefs.SetString("7-9 Timer1", "00:10");
        PlayerPrefs.SetString("7-9 Timer2", "00:20");
        PlayerPrefs.SetString("7-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-9", 0);
        PlayerPrefs.SetInt("hasJump 7-9", 0);
        PlayerPrefs.SetInt("hasNug 7-9", 0);

        PlayerPrefs.SetString("7-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("7-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("7-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("7-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 7-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 7-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 7-Hidden", 0);

    }

    private void WorldEightStats()
    {
        PlayerPrefs.SetString("8-1Title", "Introduction");
        PlayerPrefs.SetString("8-1 Timer1", "00:10");
        PlayerPrefs.SetString("8-1 Timer2", "00:20");
        PlayerPrefs.SetString("8-1 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-1", 0);
        PlayerPrefs.SetInt("hasJump 8-1", 0);
        PlayerPrefs.SetInt("hasNug 8-1", 0);

        PlayerPrefs.SetString("8-2Title", "Introduction");
        PlayerPrefs.SetString("8-2 Timer1", "00:10");
        PlayerPrefs.SetString("8-2 Timer2", "00:20");
        PlayerPrefs.SetString("8-2 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-2", 0);
        PlayerPrefs.SetInt("hasJump 8-2", 0);
        PlayerPrefs.SetInt("hasNug 8-2", 0);

        PlayerPrefs.SetString("8-3Title", "Introduction");
        PlayerPrefs.SetString("8-3 Timer1", "00:10");
        PlayerPrefs.SetString("8-3 Timer2", "00:20");
        PlayerPrefs.SetString("8-3 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-3", 0);
        PlayerPrefs.SetInt("hasJump 8-3", 0);
        PlayerPrefs.SetInt("hasNug 8-3", 0);

        PlayerPrefs.SetString("8-4Title", "Introduction");
        PlayerPrefs.SetString("8-4 Timer1", "00:10");
        PlayerPrefs.SetString("8-4 Timer2", "00:20");
        PlayerPrefs.SetString("8-4 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-4", 0);
        PlayerPrefs.SetInt("hasJump 8-4", 0);
        PlayerPrefs.SetInt("hasNug 8-4", 0);

        PlayerPrefs.SetString("8-5Title", "Introduction");
        PlayerPrefs.SetString("8-5 Timer1", "00:10");
        PlayerPrefs.SetString("8-5 Timer2", "00:20");
        PlayerPrefs.SetString("8-5 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-5", 0);
        PlayerPrefs.SetInt("hasJump 8-5", 0);
        PlayerPrefs.SetInt("hasNug 8-5", 0);

        PlayerPrefs.SetString("8-6Title", "Introduction");
        PlayerPrefs.SetString("8-6 Timer1", "00:10");
        PlayerPrefs.SetString("8-6 Timer2", "00:20");
        PlayerPrefs.SetString("8-6 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-6", 0);
        PlayerPrefs.SetInt("hasJump 8-6", 0);
        PlayerPrefs.SetInt("hasNug 8-6", 0);

        PlayerPrefs.SetString("8-7Title", "Introduction");
        PlayerPrefs.SetString("8-7 Timer1", "00:10");
        PlayerPrefs.SetString("8-7 Timer2", "00:20");
        PlayerPrefs.SetString("8-7 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-7", 0);
        PlayerPrefs.SetInt("hasJump 8-7", 0);
        PlayerPrefs.SetInt("hasNug 8-7", 0);

        PlayerPrefs.SetString("8-8Title", "Introduction");
        PlayerPrefs.SetString("8-8 Timer1", "00:10");
        PlayerPrefs.SetString("8-8 Timer2", "00:20");
        PlayerPrefs.SetString("8-8 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-8", 0);
        PlayerPrefs.SetInt("hasJump 8-8", 0);
        PlayerPrefs.SetInt("hasNug 8-8", 0);

        PlayerPrefs.SetString("8-9Title", "Introduction");
        PlayerPrefs.SetString("8-9 Timer1", "00:10");
        PlayerPrefs.SetString("8-9 Timer2", "00:20");
        PlayerPrefs.SetString("8-9 Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-9", 0);
        PlayerPrefs.SetInt("hasJump 8-9", 0);
        PlayerPrefs.SetInt("hasNug 8-9", 0);

        PlayerPrefs.SetString("8-HiddenTitle", "Introduction");
        PlayerPrefs.SetString("8-Hidden Timer1", "00:10");
        PlayerPrefs.SetString("8-Hidden Timer2", "00:20");
        PlayerPrefs.SetString("8-Hidden Timer3", "00:30");
        PlayerPrefs.SetInt("hasActivate 8-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 8-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 8-Hidden", 0);
    }

    private void SetTimers()
    {
        PlayerPrefs.SetInt("RunOnce", 1);
        PlayerPrefs.SetFloat("bestTime 1-1", 0);
        PlayerPrefs.SetFloat("bestTime 1-2", 0);
        PlayerPrefs.SetFloat("bestTime 1-3", 0);
        PlayerPrefs.SetFloat("bestTime 1-4", 0);
        PlayerPrefs.SetFloat("bestTime 1-5", 0);
        PlayerPrefs.SetFloat("bestTime 1-6", 0);
        PlayerPrefs.SetFloat("bestTime 1-7", 0);
        PlayerPrefs.SetFloat("bestTime 1-8", 0);
        PlayerPrefs.SetFloat("bestTime 1-9", 0);
        PlayerPrefs.SetFloat("bestTime 1-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 2-1", 0);
        PlayerPrefs.SetFloat("bestTime 2-2", 0);
        PlayerPrefs.SetFloat("bestTime 2-3", 0);
        PlayerPrefs.SetFloat("bestTime 2-4", 0);
        PlayerPrefs.SetFloat("bestTime 2-5", 0);
        PlayerPrefs.SetFloat("bestTime 2-6", 0);
        PlayerPrefs.SetFloat("bestTime 2-7", 0);
        PlayerPrefs.SetFloat("bestTime 2-8", 0);
        PlayerPrefs.SetFloat("bestTime 2-9", 0);
        PlayerPrefs.SetFloat("bestTime 2-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 3-1", 0);
        PlayerPrefs.SetFloat("bestTime 3-2", 0);
        PlayerPrefs.SetFloat("bestTime 3-3", 0);
        PlayerPrefs.SetFloat("bestTime 3-4", 0);
        PlayerPrefs.SetFloat("bestTime 3-5", 0);
        PlayerPrefs.SetFloat("bestTime 3-6", 0);
        PlayerPrefs.SetFloat("bestTime 3-7", 0);
        PlayerPrefs.SetFloat("bestTime 3-8", 0);
        PlayerPrefs.SetFloat("bestTime 3-9", 0);
        PlayerPrefs.SetFloat("bestTime 3-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 4-1", 0);
        PlayerPrefs.SetFloat("bestTime 4-2", 0);
        PlayerPrefs.SetFloat("bestTime 4-3", 0);
        PlayerPrefs.SetFloat("bestTime 4-4", 0);
        PlayerPrefs.SetFloat("bestTime 4-5", 0);
        PlayerPrefs.SetFloat("bestTime 4-6", 0);
        PlayerPrefs.SetFloat("bestTime 4-7", 0);
        PlayerPrefs.SetFloat("bestTime 4-8", 0);
        PlayerPrefs.SetFloat("bestTime 4-9", 0);
        PlayerPrefs.SetFloat("bestTime 4-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 5-1", 0);
        PlayerPrefs.SetFloat("bestTime 5-2", 0);
        PlayerPrefs.SetFloat("bestTime 5-3", 0);
        PlayerPrefs.SetFloat("bestTime 5-4", 0);
        PlayerPrefs.SetFloat("bestTime 5-5", 0);
        PlayerPrefs.SetFloat("bestTime 5-6", 0);
        PlayerPrefs.SetFloat("bestTime 5-7", 0);
        PlayerPrefs.SetFloat("bestTime 5-8", 0);
        PlayerPrefs.SetFloat("bestTime 5-9", 0);
        PlayerPrefs.SetFloat("bestTime 5-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 6-1", 0);
        PlayerPrefs.SetFloat("bestTime 6-2", 0);
        PlayerPrefs.SetFloat("bestTime 6-3", 0);
        PlayerPrefs.SetFloat("bestTime 6-4", 0);
        PlayerPrefs.SetFloat("bestTime 6-5", 0);
        PlayerPrefs.SetFloat("bestTime 6-6", 0);
        PlayerPrefs.SetFloat("bestTime 6-7", 0);
        PlayerPrefs.SetFloat("bestTime 6-8", 0);
        PlayerPrefs.SetFloat("bestTime 6-9", 0);
        PlayerPrefs.SetFloat("bestTime 6-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 7-1", 0);
        PlayerPrefs.SetFloat("bestTime 7-2", 0);
        PlayerPrefs.SetFloat("bestTime 7-3", 0);
        PlayerPrefs.SetFloat("bestTime 7-4", 0);
        PlayerPrefs.SetFloat("bestTime 7-5", 0);
        PlayerPrefs.SetFloat("bestTime 7-6", 0);
        PlayerPrefs.SetFloat("bestTime 7-7", 0);
        PlayerPrefs.SetFloat("bestTime 7-8", 0);
        PlayerPrefs.SetFloat("bestTime 7-9", 0);
        PlayerPrefs.SetFloat("bestTime 7-Hidden", 0);

        PlayerPrefs.SetFloat("bestTime 8-1", 0);
        PlayerPrefs.SetFloat("bestTime 8-2", 0);
        PlayerPrefs.SetFloat("bestTime 8-3", 0);
        PlayerPrefs.SetFloat("bestTime 8-4", 0);
        PlayerPrefs.SetFloat("bestTime 8-5", 0);
        PlayerPrefs.SetFloat("bestTime 8-6", 0);
        PlayerPrefs.SetFloat("bestTime 8-7", 0);
        PlayerPrefs.SetFloat("bestTime 8-8", 0);
        PlayerPrefs.SetFloat("bestTime 8-9", 0);
        PlayerPrefs.SetFloat("bestTime 8-Hidden", 0);
    }

    public void SetAttempts()
    {
        PlayerPrefs.SetInt("bestAttempts 1-1", 0);
        PlayerPrefs.SetInt("totalAttempts 1-1", 0);

        PlayerPrefs.SetInt("bestAttempts 1-2", 0);
        PlayerPrefs.SetInt("totalAttempts 1-2", 0);

        PlayerPrefs.SetInt("bestAttempts 1-3", 0);
        PlayerPrefs.SetInt("totalAttempts 1-3", 0);

        PlayerPrefs.SetInt("bestAttempts 1-4", 0);
        PlayerPrefs.SetInt("totalAttempts 1-4", 0);

        PlayerPrefs.SetInt("bestAttempts 1-5", 0);
        PlayerPrefs.SetInt("totalAttempts 1-5", 0);

        PlayerPrefs.SetInt("bestAttempts 1-6", 0);
        PlayerPrefs.SetInt("totalAttempts 1-6", 0);

        PlayerPrefs.SetInt("bestAttempts 1-7", 0);
        PlayerPrefs.SetInt("totalAttempts 1-7", 0);

        PlayerPrefs.SetInt("bestAttempts 1-8", 0);
        PlayerPrefs.SetInt("totalAttempts 1-8", 0);

        PlayerPrefs.SetInt("bestAttempts 1-9", 0);
        PlayerPrefs.SetInt("totalAttempts 1-9", 0);

        PlayerPrefs.SetInt("bestAttempts 1-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 1-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 2-1", 0);
        PlayerPrefs.SetInt("totalAttempts 2-1", 0);

        PlayerPrefs.SetInt("bestAttempts 2-2", 0);
        PlayerPrefs.SetInt("totalAttempts 2-2", 0);

        PlayerPrefs.SetInt("bestAttempts 2-3", 0);
        PlayerPrefs.SetInt("totalAttempts 2-3", 0);

        PlayerPrefs.SetInt("bestAttempts 2-4", 0);
        PlayerPrefs.SetInt("totalAttempts 2-4", 0);

        PlayerPrefs.SetInt("bestAttempts 2-5", 0);
        PlayerPrefs.SetInt("totalAttempts 2-5", 0);

        PlayerPrefs.SetInt("bestAttempts 2-6", 0);
        PlayerPrefs.SetInt("totalAttempts 2-6", 0);

        PlayerPrefs.SetInt("bestAttempts 2-7", 0);
        PlayerPrefs.SetInt("totalAttempts 2-7", 0);

        PlayerPrefs.SetInt("bestAttempts 2-8", 0);
        PlayerPrefs.SetInt("totalAttempts 2-8", 0);

        PlayerPrefs.SetInt("bestAttempts 2-9", 0);
        PlayerPrefs.SetInt("totalAttempts 2-9", 0);

        PlayerPrefs.SetInt("bestAttempts 2-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 2-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 3-1", 0);
        PlayerPrefs.SetInt("totalAttempts 3-1", 0);

        PlayerPrefs.SetInt("bestAttempts 3-2", 0);
        PlayerPrefs.SetInt("totalAttempts 3-2", 0);

        PlayerPrefs.SetInt("bestAttempts 3-3", 0);
        PlayerPrefs.SetInt("totalAttempts 3-3", 0);

        PlayerPrefs.SetInt("bestAttempts 3-4", 0);
        PlayerPrefs.SetInt("totalAttempts 3-4", 0);

        PlayerPrefs.SetInt("bestAttempts 3-5", 0);
        PlayerPrefs.SetInt("totalAttempts 3-5", 0);

        PlayerPrefs.SetInt("bestAttempts 3-6", 0);
        PlayerPrefs.SetInt("totalAttempts 3-6", 0);

        PlayerPrefs.SetInt("bestAttempts 3-7", 0);
        PlayerPrefs.SetInt("totalAttempts 3-7", 0);

        PlayerPrefs.SetInt("bestAttempts 3-8", 0);
        PlayerPrefs.SetInt("totalAttempts 3-8", 0);

        PlayerPrefs.SetInt("bestAttempts 3-9", 0);
        PlayerPrefs.SetInt("totalAttempts 3-9", 0);

        PlayerPrefs.SetInt("bestAttempts 3-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 3-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 4-1", 0);
        PlayerPrefs.SetInt("totalAttempts 4-1", 0);

        PlayerPrefs.SetInt("bestAttempts 4-2", 0);
        PlayerPrefs.SetInt("totalAttempts 4-2", 0);

        PlayerPrefs.SetInt("bestAttempts 4-3", 0);
        PlayerPrefs.SetInt("totalAttempts 4-3", 0);

        PlayerPrefs.SetInt("bestAttempts 4-4", 0);
        PlayerPrefs.SetInt("totalAttempts 4-4", 0);

        PlayerPrefs.SetInt("bestAttempts 4-5", 0);
        PlayerPrefs.SetInt("totalAttempts 4-5", 0);

        PlayerPrefs.SetInt("bestAttempts 4-6", 0);
        PlayerPrefs.SetInt("totalAttempts 4-6", 0);

        PlayerPrefs.SetInt("bestAttempts 4-7", 0);
        PlayerPrefs.SetInt("totalAttempts 4-7", 0);

        PlayerPrefs.SetInt("bestAttempts 4-8", 0);
        PlayerPrefs.SetInt("totalAttempts 4-8", 0);

        PlayerPrefs.SetInt("bestAttempts 4-9", 0);
        PlayerPrefs.SetInt("totalAttempts 4-9", 0);

        PlayerPrefs.SetInt("bestAttempts 4-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 4-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 5-1", 0);
        PlayerPrefs.SetInt("totalAttempts 5-1", 0);

        PlayerPrefs.SetInt("bestAttempts 5-2", 0);
        PlayerPrefs.SetInt("totalAttempts 5-2", 0);

        PlayerPrefs.SetInt("bestAttempts 5-3", 0);
        PlayerPrefs.SetInt("totalAttempts 5-3", 0);

        PlayerPrefs.SetInt("bestAttempts 5-4", 0);
        PlayerPrefs.SetInt("totalAttempts 5-4", 0);

        PlayerPrefs.SetInt("bestAttempts 5-5", 0);
        PlayerPrefs.SetInt("totalAttempts 5-5", 0);

        PlayerPrefs.SetInt("bestAttempts 5-6", 0);
        PlayerPrefs.SetInt("totalAttempts 5-6", 0);

        PlayerPrefs.SetInt("bestAttempts 5-7", 0);
        PlayerPrefs.SetInt("totalAttempts 5-7", 0);

        PlayerPrefs.SetInt("bestAttempts 5-8", 0);
        PlayerPrefs.SetInt("totalAttempts 5-8", 0);

        PlayerPrefs.SetInt("bestAttempts 5-9", 0);
        PlayerPrefs.SetInt("totalAttempts 5-9", 0);

        PlayerPrefs.SetInt("bestAttempts 5-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 5-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 6-1", 0);
        PlayerPrefs.SetInt("totalAttempts 6-1", 0);

        PlayerPrefs.SetInt("bestAttempts 6-2", 0);
        PlayerPrefs.SetInt("totalAttempts 6-2", 0);

        PlayerPrefs.SetInt("bestAttempts 6-3", 0);
        PlayerPrefs.SetInt("totalAttempts 6-3", 0);

        PlayerPrefs.SetInt("bestAttempts 6-4", 0);
        PlayerPrefs.SetInt("totalAttempts 6-4", 0);

        PlayerPrefs.SetInt("bestAttempts 6-5", 0);
        PlayerPrefs.SetInt("totalAttempts 6-5", 0);

        PlayerPrefs.SetInt("bestAttempts 6-6", 0);
        PlayerPrefs.SetInt("totalAttempts 6-6", 0);

        PlayerPrefs.SetInt("bestAttempts 6-7", 0);
        PlayerPrefs.SetInt("totalAttempts 6-7", 0);

        PlayerPrefs.SetInt("bestAttempts 6-8", 0);
        PlayerPrefs.SetInt("totalAttempts 6-8", 0);

        PlayerPrefs.SetInt("bestAttempts 6-9", 0);
        PlayerPrefs.SetInt("totalAttempts 6-9", 0);

        PlayerPrefs.SetInt("bestAttempts 6-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 6-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 7-1", 0);
        PlayerPrefs.SetInt("totalAttempts 7-1", 0);

        PlayerPrefs.SetInt("bestAttempts 7-2", 0);
        PlayerPrefs.SetInt("totalAttempts 7-2", 0);

        PlayerPrefs.SetInt("bestAttempts 7-3", 0);
        PlayerPrefs.SetInt("totalAttempts 7-3", 0);

        PlayerPrefs.SetInt("bestAttempts 7-4", 0);
        PlayerPrefs.SetInt("totalAttempts 7-4", 0);

        PlayerPrefs.SetInt("bestAttempts 7-5", 0);
        PlayerPrefs.SetInt("totalAttempts 7-5", 0);

        PlayerPrefs.SetInt("bestAttempts 7-6", 0);
        PlayerPrefs.SetInt("totalAttempts 7-6", 0);

        PlayerPrefs.SetInt("bestAttempts 7-7", 0);
        PlayerPrefs.SetInt("totalAttempts 7-7", 0);

        PlayerPrefs.SetInt("bestAttempts 7-8", 0);
        PlayerPrefs.SetInt("totalAttempts 7-8", 0);

        PlayerPrefs.SetInt("bestAttempts 7-9", 0);
        PlayerPrefs.SetInt("totalAttempts 7-9", 0);

        PlayerPrefs.SetInt("bestAttempts 7-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 7-Hidden", 0);

        PlayerPrefs.SetInt("bestAttempts 8-1", 0);
        PlayerPrefs.SetInt("totalAttempts 8-1", 0);

        PlayerPrefs.SetInt("bestAttempts 8-2", 0);
        PlayerPrefs.SetInt("totalAttempts 8-2", 0);

        PlayerPrefs.SetInt("bestAttempts 8-3", 0);
        PlayerPrefs.SetInt("totalAttempts 8-3", 0);

        PlayerPrefs.SetInt("bestAttempts 8-4", 0);
        PlayerPrefs.SetInt("totalAttempts 8-4", 0);

        PlayerPrefs.SetInt("bestAttempts 8-5", 0);
        PlayerPrefs.SetInt("totalAttempts 8-5", 0);

        PlayerPrefs.SetInt("bestAttempts 8-6", 0);
        PlayerPrefs.SetInt("totalAttempts 8-6", 0);

        PlayerPrefs.SetInt("bestAttempts 8-7", 0);
        PlayerPrefs.SetInt("totalAttempts 8-7", 0);

        PlayerPrefs.SetInt("bestAttempts 8-8", 0);
        PlayerPrefs.SetInt("totalAttempts 8-8", 0);

        PlayerPrefs.SetInt("bestAttempts 8-9", 0);
        PlayerPrefs.SetInt("totalAttempts 8-9", 0);

        PlayerPrefs.SetInt("bestAttempts 8-Hidden", 0);
        PlayerPrefs.SetInt("totalAttempts 8-Hidden", 0);
    }

}
