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
        PlayerPrefs.SetFloat("1-1 Timer1", 15);
        PlayerPrefs.SetFloat("1-1 Timer2", 10);
        PlayerPrefs.SetFloat("1-1 Timer3", 7);
        PlayerPrefs.SetInt("hasActivate 1-1", 0);
        PlayerPrefs.SetInt("hasJump 1-1", 0);
        PlayerPrefs.SetInt("hasNug 1-1", 0);

        PlayerPrefs.SetString("1-2Title", "Activation");
        PlayerPrefs.SetFloat("1-2 Timer1", 20);
        PlayerPrefs.SetFloat("1-2 Timer2", 13);
        PlayerPrefs.SetFloat("1-2 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 1-2", 1);
        PlayerPrefs.SetInt("hasJump 1-2", 0);
        PlayerPrefs.SetInt("hasNug 1-2", 0);

        PlayerPrefs.SetString("1-3Title", "Get them all");
        PlayerPrefs.SetFloat("1-3 Timer1", 30);
        PlayerPrefs.SetFloat("1-3 Timer2", 20);
        PlayerPrefs.SetFloat("1-3 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 1-3", 1);
        PlayerPrefs.SetInt("hasJump 1-3", 0);
        PlayerPrefs.SetInt("hasNug 1-3", 0);

        PlayerPrefs.SetString("1-4Title", "Watch out below");
        PlayerPrefs.SetFloat("1-4 Timer1", 40);
        PlayerPrefs.SetFloat("1-4 Timer2", 30);
        PlayerPrefs.SetFloat("1-4 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 1-4", 1);
        PlayerPrefs.SetInt("hasJump 1-4", 0);
        PlayerPrefs.SetInt("hasNug 1-4", 0);

        PlayerPrefs.SetString("1-5Title", "Do it in the order");
        PlayerPrefs.SetFloat("1-5 Timer1", 60);
        PlayerPrefs.SetFloat("1-5 Timer2", 45);
        PlayerPrefs.SetFloat("1-5 Timer3", 30);
        PlayerPrefs.SetInt("hasActivate 1-5", 1);
        PlayerPrefs.SetInt("hasJump 1-5", 0);
        PlayerPrefs.SetInt("hasNug 1-5", 0);

        PlayerPrefs.SetString("1-6Title", "Are seals good?");
        PlayerPrefs.SetFloat("1-6 Timer1", 50);
        PlayerPrefs.SetFloat("1-6 Timer2", 40);
        PlayerPrefs.SetFloat("1-6 Timer3", 35);
        PlayerPrefs.SetInt("hasActivate 1-6", 1);
        PlayerPrefs.SetInt("hasJump 1-6", 0);
        PlayerPrefs.SetInt("hasNug 1-6", 1);

        PlayerPrefs.SetString("1-7Title", "Back to the start");
        PlayerPrefs.SetFloat("1-7 Timer1", 80);
        PlayerPrefs.SetFloat("1-7 Timer2", 60);
        PlayerPrefs.SetFloat("1-7 Timer3", 50);
        PlayerPrefs.SetInt("hasActivate 1-7", 1);
        PlayerPrefs.SetInt("hasJump 1-7", 0);
        PlayerPrefs.SetInt("hasNug 1-7", 0);
  
        PlayerPrefs.SetString("1-8Title", "Better run fast");
        PlayerPrefs.SetFloat("1-8 Timer1", 30);
        PlayerPrefs.SetFloat("1-8 Timer2", 15);
        PlayerPrefs.SetFloat("1-8 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 1-8", 1);
        PlayerPrefs.SetInt("hasJump 1-8", 0);
        PlayerPrefs.SetInt("hasNug 1-8", 0);

        PlayerPrefs.SetString("1-9Title", "Concentrate");
        PlayerPrefs.SetFloat("1-9 Timer1", 120);
        PlayerPrefs.SetFloat("1-9 Timer2", 100);
        PlayerPrefs.SetFloat("1-9 Timer3", 80);
        PlayerPrefs.SetInt("hasActivate 1-9", 1);
        PlayerPrefs.SetInt("hasJump 1-9", 0);
        PlayerPrefs.SetInt("hasNug 1-9", 0);

        PlayerPrefs.SetString("1-HiddenTitle", "Can't penguins fly?");
        PlayerPrefs.SetFloat("1-Hidden Timer1", 45);
        PlayerPrefs.SetFloat("1-Hidden Timer2", 20);
        PlayerPrefs.SetFloat("1-Hidden Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 1-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 1-Hidden", 1);
        PlayerPrefs.SetInt("hasNug 1-Hidden", 0);
    }

    private void WorldTwoStats()
    {
        PlayerPrefs.SetString("2-1Title", "Let's get jumping");
        PlayerPrefs.SetFloat("2-1 Timer1", 25);
        PlayerPrefs.SetFloat("2-1 Timer2", 20);
        PlayerPrefs.SetFloat("2-1 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 2-1", 0);
        PlayerPrefs.SetInt("hasJump 2-1", 1);
        PlayerPrefs.SetInt("hasNug 2-1", 0);

        PlayerPrefs.SetString("2-2Title", "Is this even possible?");
        PlayerPrefs.SetFloat("2-2 Timer1", 20);
        PlayerPrefs.SetFloat("2-2 Timer2", 13);
        PlayerPrefs.SetFloat("2-2 Timer3", 8);
        PlayerPrefs.SetInt("hasActivate 2-2", 0);
        PlayerPrefs.SetInt("hasJump 2-2", 0);
        PlayerPrefs.SetInt("hasNug 2-2", 0);

        PlayerPrefs.SetString("2-3Title", "Leap of faith");
        PlayerPrefs.SetFloat("2-3 Timer1", 20);
        PlayerPrefs.SetFloat("2-3 Timer2",13);
        PlayerPrefs.SetFloat("2-3 Timer3", 9);
        PlayerPrefs.SetInt("hasActivate 2-3", 0);
        PlayerPrefs.SetInt("hasJump 2-3", 1);
        PlayerPrefs.SetInt("hasNug 2-3", 0);

        PlayerPrefs.SetString("2-4Title", "Are penguins that mean?");
        PlayerPrefs.SetFloat("2-4 Timer1", 30);
        PlayerPrefs.SetFloat("2-4 Timer2", 20);
        PlayerPrefs.SetFloat("2-4 Timer3", 12);
        PlayerPrefs.SetInt("hasActivate 2-4", 0);
        PlayerPrefs.SetInt("hasJump 2-4", 0);
        PlayerPrefs.SetInt("hasNug 2-4", 0);

        PlayerPrefs.SetString("2-5Title", "Moving the nest");
        PlayerPrefs.SetFloat("2-5 Timer1", 100);
        PlayerPrefs.SetFloat("2-5 Timer2", 70);
        PlayerPrefs.SetFloat("2-5 Timer3", 50);
        PlayerPrefs.SetInt("hasActivate 2-5", 0);
        PlayerPrefs.SetInt("hasJump 2-5", 1);
        PlayerPrefs.SetInt("hasNug 2-5", 0);

        PlayerPrefs.SetString("2-6Title", "Can snow move?");
        PlayerPrefs.SetFloat("2-6 Timer1", 25);
        PlayerPrefs.SetFloat("2-6 Timer2", 20);
        PlayerPrefs.SetFloat("2-6 Timer3", 14);
        PlayerPrefs.SetInt("hasActivate 2-6", 0);
        PlayerPrefs.SetInt("hasJump 2-6", 1);
        PlayerPrefs.SetInt("hasNug 2-6", 0);

        PlayerPrefs.SetString("2-7Title", "Yes, penguins really are that mean");
        PlayerPrefs.SetFloat("2-7 Timer1", 45);
        PlayerPrefs.SetFloat("2-7 Timer2", 35);
        PlayerPrefs.SetFloat("2-7 Timer3", 25);
        PlayerPrefs.SetInt("hasActivate 2-7", 0);
        PlayerPrefs.SetInt("hasJump 2-7", 1);
        PlayerPrefs.SetInt("hasNug 2-7", 0);

        PlayerPrefs.SetString("2-8Title", "Are there even a pattern to this?");
        PlayerPrefs.SetFloat("2-8 Timer1", 40);
        PlayerPrefs.SetFloat("2-8 Timer2", 30);
        PlayerPrefs.SetFloat("2-8 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 2-8", 0);
        PlayerPrefs.SetInt("hasJump 2-8", 0);
        PlayerPrefs.SetInt("hasNug 2-8", 0);

        PlayerPrefs.SetString("2-9Title", "Don't look down");
        PlayerPrefs.SetFloat("2-9 Timer1", 120);
        PlayerPrefs.SetFloat("2-9 Timer2", 100);
        PlayerPrefs.SetFloat("2-9 Timer3", 80);
        PlayerPrefs.SetInt("hasActivate 2-9", 0);
        PlayerPrefs.SetInt("hasJump 2-9", 0);
        PlayerPrefs.SetInt("hasNug 2-9", 1);

        PlayerPrefs.SetString("2-HiddenTitle", "Watch out for seals");
        PlayerPrefs.SetFloat("2-Hidden Timer1", 50);
        PlayerPrefs.SetFloat("2-Hidden Timer2", 40);
        PlayerPrefs.SetFloat("2-Hidden Timer3", 30);
        PlayerPrefs.SetInt("hasActivate 2-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 2-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 2-Hidden", 0);

    }

    private void WorldThreeStats()
    {
        PlayerPrefs.SetString("3-1Title", "Snowmen!");
        PlayerPrefs.SetFloat("3-1 Timer1", 40);
        PlayerPrefs.SetFloat("3-1 Timer2", 30);
        PlayerPrefs.SetFloat("3-1 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 3-1", 0);
        PlayerPrefs.SetInt("hasJump 3-1", 0);
        PlayerPrefs.SetInt("hasNug 3-1", 0);

        PlayerPrefs.SetString("3-2Title", "This is getting out of hand..");
        PlayerPrefs.SetFloat("3-2 Timer1", 50);
        PlayerPrefs.SetFloat("3-2 Timer2", 35);
        PlayerPrefs.SetFloat("3-2 Timer3", 25);
        PlayerPrefs.SetInt("hasActivate 3-2", 0);
        PlayerPrefs.SetInt("hasJump 3-2", 0);
        PlayerPrefs.SetInt("hasNug 3-2", 0);

        PlayerPrefs.SetString("3-3Title", "Which way will you choose?");
        PlayerPrefs.SetFloat("3-3 Timer1", 40);
        PlayerPrefs.SetFloat("3-3 Timer2", 30);
        PlayerPrefs.SetFloat("3-3 Timer3", 25);
        PlayerPrefs.SetInt("hasActivate 3-3", 0);
        PlayerPrefs.SetInt("hasJump 3-3", 0);
        PlayerPrefs.SetInt("hasNug 3-3", 0);

        PlayerPrefs.SetString("3-4Title", "Find the way");
        PlayerPrefs.SetFloat("3-4 Timer1", 30);
        PlayerPrefs.SetFloat("3-4 Timer2",20);
        PlayerPrefs.SetFloat("3-4 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 3-4", 0);
        PlayerPrefs.SetInt("hasJump 3-4", 0);
        PlayerPrefs.SetInt("hasNug 3-4", 0);

        PlayerPrefs.SetString("3-5Title", "Fast reactions");
        PlayerPrefs.SetFloat("3-5 Timer1", 100);
        PlayerPrefs.SetFloat("3-5 Timer2", 80);
        PlayerPrefs.SetFloat("3-5 Timer3", 60);
        PlayerPrefs.SetInt("hasActivate 3-5", 1);
        PlayerPrefs.SetInt("hasJump 3-5", 1);
        PlayerPrefs.SetInt("hasNug 3-5", 0);

        PlayerPrefs.SetString("3-6Title", "It's all about the timing");
        PlayerPrefs.SetFloat("3-6 Timer1", 20);
        PlayerPrefs.SetFloat("3-6 Timer2", 15);
        PlayerPrefs.SetFloat("3-6 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 3-6", 0);
        PlayerPrefs.SetInt("hasJump 3-6", 0);
        PlayerPrefs.SetInt("hasNug 3-6", 0);

        PlayerPrefs.SetString("3-7Title", "Gotta go forward to get back");
        PlayerPrefs.SetFloat("3-7 Timer1", 50);
        PlayerPrefs.SetFloat("3-7 Timer2", 40);
        PlayerPrefs.SetFloat("3-7 Timer3", 30);
        PlayerPrefs.SetInt("hasActivate 3-7", 1);
        PlayerPrefs.SetInt("hasJump 3-7", 1);
        PlayerPrefs.SetInt("hasNug 3-7", 1);

        PlayerPrefs.SetString("3-8Title", "Can this even be timed?");
        PlayerPrefs.SetFloat("3-8 Timer1", 25);
        PlayerPrefs.SetFloat("3-8 Timer2", 20);
        PlayerPrefs.SetFloat("3-8 Timer3", 13);
        PlayerPrefs.SetInt("hasActivate 3-8", 0);
        PlayerPrefs.SetInt("hasJump 3-8", 0);
        PlayerPrefs.SetInt("hasNug 3-8", 0);

        PlayerPrefs.SetString("3-9Title", "Wrong place, wrong time");
        PlayerPrefs.SetFloat("3-9 Timer1", 75);
        PlayerPrefs.SetFloat("3-9 Timer2", 60);
        PlayerPrefs.SetFloat("3-9 Timer3", 45);
        PlayerPrefs.SetInt("hasActivate 3-9", 1);
        PlayerPrefs.SetInt("hasJump 3-9", 1);
        PlayerPrefs.SetInt("hasNug 3-9", 0);

        PlayerPrefs.SetString("3-HiddenTitle", "Precision..");
        PlayerPrefs.SetFloat("3-Hidden Timer1", 100);
        PlayerPrefs.SetFloat("3-Hidden Timer2", 80);
        PlayerPrefs.SetFloat("3-Hidden Timer3", 50);
        PlayerPrefs.SetInt("hasActivate 1-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 3-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 3-Hidden", 0);

    }

    private void WorldFourStats()
    {
        PlayerPrefs.SetString("4-1Title", "Back to basics");
        PlayerPrefs.SetFloat("4-1 Timer1", 60);
        PlayerPrefs.SetFloat("4-1 Timer2", 50);
        PlayerPrefs.SetFloat("4-1 Timer3", 40);
        PlayerPrefs.SetInt("hasActivate 4-1", 1);
        PlayerPrefs.SetInt("hasJump 4-1", 0);
        PlayerPrefs.SetInt("hasNug 4-1", 1);

        PlayerPrefs.SetString("4-2Title", "Why are the holes squares?");
        PlayerPrefs.SetFloat("4-2 Timer1", 40);
        PlayerPrefs.SetFloat("4-2 Timer2", 30);
        PlayerPrefs.SetFloat("4-2 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 4-2", 0);
        PlayerPrefs.SetInt("hasJump 4-2", 0);
        PlayerPrefs.SetInt("hasNug 4-2", 0);

        PlayerPrefs.SetString("4-3Title", "You are smaller than you think");
        PlayerPrefs.SetFloat("4-3 Timer1", 50);
        PlayerPrefs.SetFloat("4-3 Timer2", 40);
        PlayerPrefs.SetFloat("4-3 Timer3", 30);
        PlayerPrefs.SetInt("hasActivate 4-3", 0);
        PlayerPrefs.SetInt("hasJump 4-3", 0);
        PlayerPrefs.SetInt("hasNug 4-3", 0);

        PlayerPrefs.SetString("4-4Title", "Patrolling seal");
        PlayerPrefs.SetFloat("4-4 Timer1", 45);
        PlayerPrefs.SetFloat("4-4 Timer2", 30);
        PlayerPrefs.SetFloat("4-4 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 4-4", 0);
        PlayerPrefs.SetInt("hasJump 4-4", 0);
        PlayerPrefs.SetInt("hasNug 4-4", 0);

        PlayerPrefs.SetString("4-5Title", "What are they doing here?");
        PlayerPrefs.SetFloat("4-5 Timer1", 20);
        PlayerPrefs.SetFloat("4-5 Timer2", 12);
        PlayerPrefs.SetFloat("4-5 Timer3", 6);
        PlayerPrefs.SetInt("hasActivate 4-5", 0);
        PlayerPrefs.SetInt("hasJump 4-5", 0);
        PlayerPrefs.SetInt("hasNug 4-5", 0);

        PlayerPrefs.SetString("4-6Title", "Need to be smart about this");
        PlayerPrefs.SetFloat("4-6 Timer1",20);
        PlayerPrefs.SetFloat("4-6 Timer2", 15);
        PlayerPrefs.SetFloat("4-6 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 4-6", 0);
        PlayerPrefs.SetInt("hasJump 4-6", 0);
        PlayerPrefs.SetInt("hasNug 4-6", 0);

        PlayerPrefs.SetString("4-7Title", "Get to the boat!");
        PlayerPrefs.SetFloat("4-7 Timer1", 20);
        PlayerPrefs.SetFloat("4-7 Timer2", 15);
        PlayerPrefs.SetFloat("4-7 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 4-7", 0);
        PlayerPrefs.SetInt("hasJump 4-7", 1);
        PlayerPrefs.SetInt("hasNug 4-7", 0);

        PlayerPrefs.SetString("4-8Title", "Am i the captain?");
        PlayerPrefs.SetFloat("4-8 Timer1",20);
        PlayerPrefs.SetFloat("4-8 Timer2", 13);
        PlayerPrefs.SetFloat("4-8 Timer3", 8);
        PlayerPrefs.SetInt("hasActivate 4-8", 0);
        PlayerPrefs.SetInt("hasJump 4-8", 0);
        PlayerPrefs.SetInt("hasNug 4-8", 0);

        PlayerPrefs.SetString("4-9Title", "Land Ohoy");
        PlayerPrefs.SetFloat("4-9 Timer1", 15);
        PlayerPrefs.SetFloat("4-9 Timer2", 12);
        PlayerPrefs.SetFloat("4-9 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 4-9", 0);
        PlayerPrefs.SetInt("hasJump 4-9", 1);
        PlayerPrefs.SetInt("hasNug 4-9", 0);

        PlayerPrefs.SetString("4-HiddenTitle", "No shortcuts");
        PlayerPrefs.SetFloat("4-Hidden Timer1", 30);
        PlayerPrefs.SetFloat("4-Hidden Timer2", 25);
        PlayerPrefs.SetFloat("4-Hidden Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 4-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 4-Hidden", 1);
        PlayerPrefs.SetInt("hasNug 4-Hidden", 0);

    }

    private void WorldFiveStats()
    {
        PlayerPrefs.SetString("5-1Title", "Is that quicksand?");
        PlayerPrefs.SetFloat("5-1 Timer1", 20);
        PlayerPrefs.SetFloat("5-1 Timer2", 16);
        PlayerPrefs.SetFloat("5-1 Timer3", 12);
        PlayerPrefs.SetInt("hasActivate 5-1", 1);
        PlayerPrefs.SetInt("hasJump 5-1", 0);
        PlayerPrefs.SetInt("hasNug 5-1", 0);

        PlayerPrefs.SetString("5-2Title", "Desert? not a penguins favorite");
        PlayerPrefs.SetFloat("5-2 Timer1", 30);
        PlayerPrefs.SetFloat("5-2 Timer2", 20);
        PlayerPrefs.SetFloat("5-2 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 5-2", 1);
        PlayerPrefs.SetInt("hasJump 5-2", 0);
        PlayerPrefs.SetInt("hasNug 5-2", 0);

        PlayerPrefs.SetString("5-3Title", "Smart moves");
        PlayerPrefs.SetFloat("5-3 Timer1", 30);
        PlayerPrefs.SetFloat("5-3 Timer2", 20);
        PlayerPrefs.SetFloat("5-3 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 5-3", 0);
        PlayerPrefs.SetInt("hasJump 5-3", 0);
        PlayerPrefs.SetInt("hasNug 5-3", 0);

        PlayerPrefs.SetString("5-4Title", "Floating rocks?");
        PlayerPrefs.SetFloat("5-4 Timer1",20);
        PlayerPrefs.SetFloat("5-4 Timer2", 15);
        PlayerPrefs.SetFloat("5-4 Timer3", 12);
        PlayerPrefs.SetInt("hasActivate 5-4", 0);
        PlayerPrefs.SetInt("hasJump 5-4", 0);
        PlayerPrefs.SetInt("hasNug 5-4", 0);

        PlayerPrefs.SetString("5-5Title", "Scorpions, really?");
        PlayerPrefs.SetFloat("5-5 Timer1", 40);
        PlayerPrefs.SetFloat("5-5 Timer2", 30);
        PlayerPrefs.SetFloat("5-5 Timer3", 25);
        PlayerPrefs.SetInt("hasActivate 5-5", 1);
        PlayerPrefs.SetInt("hasJump 5-5", 0);
        PlayerPrefs.SetInt("hasNug 5-5", 0);

        PlayerPrefs.SetString("5-6Title", "Snakes? I hate snakes..");
        PlayerPrefs.SetFloat("5-6 Timer1", 30);
        PlayerPrefs.SetFloat("5-6 Timer2", 20);
        PlayerPrefs.SetFloat("5-6 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 5-6", 0);
        PlayerPrefs.SetInt("hasJump 5-6", 0);
        PlayerPrefs.SetInt("hasNug 5-6", 0);

        PlayerPrefs.SetString("5-7Title", "Cactus hell");
        PlayerPrefs.SetFloat("5-7 Timer1", 30);
        PlayerPrefs.SetFloat("5-7 Timer2", 20);
        PlayerPrefs.SetFloat("5-7 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 5-7", 1);
        PlayerPrefs.SetInt("hasJump 5-7", 0);
        PlayerPrefs.SetInt("hasNug 5-7", 0);

        PlayerPrefs.SetString("5-8Title", "How did they get here?");
        PlayerPrefs.SetFloat("5-8 Timer1", 25);
        PlayerPrefs.SetFloat("5-8 Timer2", 15);
        PlayerPrefs.SetFloat("5-8 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 5-8", 0);
        PlayerPrefs.SetInt("hasJump 5-8", 0);
        PlayerPrefs.SetInt("hasNug 5-8", 1);

        PlayerPrefs.SetString("5-9Title", "Dont fall down");
        PlayerPrefs.SetFloat("5-9 Timer1", 20);
        PlayerPrefs.SetFloat("5-9 Timer2", 15);
        PlayerPrefs.SetFloat("5-9 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 5-9", 0);
        PlayerPrefs.SetInt("hasJump 5-9", 1);
        PlayerPrefs.SetInt("hasNug 5-9", 0);

        PlayerPrefs.SetString("5-HiddenTitle", "Smart routing");
        PlayerPrefs.SetFloat("5-Hidden Timer1", 45);
        PlayerPrefs.SetFloat("5-Hidden Timer2", 25);
        PlayerPrefs.SetFloat("5-Hidden Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 5-Hidden", 1);
        PlayerPrefs.SetInt("hasJump 5-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 5-Hidden", 0);

    }

    private void WorldSixStats()
    {
        PlayerPrefs.SetString("6-1Title", "Back to basics 2");
        PlayerPrefs.SetFloat("6-1 Timer1", 40);
        PlayerPrefs.SetFloat("6-1 Timer2", 25);
        PlayerPrefs.SetFloat("6-1 Timer3", 17);
        PlayerPrefs.SetInt("hasActivate 6-1", 0);
        PlayerPrefs.SetInt("hasJump 6-1", 0);
        PlayerPrefs.SetInt("hasNug 6-1", 0);

        PlayerPrefs.SetString("6-2Title", "Is this a??? No...");
        PlayerPrefs.SetFloat("6-2 Timer1", 40);
        PlayerPrefs.SetFloat("6-2 Timer2", 30);
        PlayerPrefs.SetFloat("6-2 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 6-2", 1);
        PlayerPrefs.SetInt("hasJump 6-2", 0);
        PlayerPrefs.SetInt("hasNug 6-2", 0);

        PlayerPrefs.SetString("6-3Title", "Mesmerizing");
        PlayerPrefs.SetFloat("6-3 Timer1", 70);
        PlayerPrefs.SetFloat("6-3 Timer2", 50);
        PlayerPrefs.SetFloat("6-3 Timer3", 35);
        PlayerPrefs.SetInt("hasActivate 6-3", 1);
        PlayerPrefs.SetInt("hasJump 6-3", 0);
        PlayerPrefs.SetInt("hasNug 6-3", 0);

        PlayerPrefs.SetString("6-4Title", "Is this a natural phenomenon?");
        PlayerPrefs.SetFloat("6-4 Timer1", 40);
        PlayerPrefs.SetFloat("6-4 Timer2", 25);
        PlayerPrefs.SetFloat("6-4 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 6-4", 0);
        PlayerPrefs.SetInt("hasJump 6-4", 0);
        PlayerPrefs.SetInt("hasNug 6-4", 0);

        PlayerPrefs.SetString("6-5Title", "How does it float?");
        PlayerPrefs.SetFloat("6-5 Timer1", 25);
        PlayerPrefs.SetFloat("6-5 Timer2", 15);
        PlayerPrefs.SetFloat("6-5 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 6-5", 0);
        PlayerPrefs.SetInt("hasJump 6-5", 0);
        PlayerPrefs.SetInt("hasNug 6-5", 0);

        PlayerPrefs.SetString("6-6Title", "Leap of faith 2");
        PlayerPrefs.SetFloat("6-6 Timer1", 60);
        PlayerPrefs.SetFloat("6-6 Timer2", 45);
        PlayerPrefs.SetFloat("6-6 Timer3", 30);
        PlayerPrefs.SetInt("hasActivate 6-6", 0);
        PlayerPrefs.SetInt("hasJump 6-6", 1);
        PlayerPrefs.SetInt("hasNug 6-6", 0);

        PlayerPrefs.SetString("6-7Title", "Don't get in their way");
        PlayerPrefs.SetFloat("6-7 Timer1", 40);
        PlayerPrefs.SetFloat("6-7 Timer2", 35);
        PlayerPrefs.SetFloat("6-7 Timer3", 25);
        PlayerPrefs.SetInt("hasActivate 6-7", 1);
        PlayerPrefs.SetInt("hasJump 6-7", 0);
        PlayerPrefs.SetInt("hasNug 6-7", 0);

        PlayerPrefs.SetString("6-8Title", "Is something hidden here?");
        PlayerPrefs.SetFloat("6-8 Timer1", 35);
        PlayerPrefs.SetFloat("6-8 Timer2", 25);
        PlayerPrefs.SetFloat("6-8 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 6-8", 0);
        PlayerPrefs.SetInt("hasJump 6-8", 0);
        PlayerPrefs.SetInt("hasNug 6-8", 1);

        PlayerPrefs.SetString("6-9Title", "One path at a time");
        PlayerPrefs.SetFloat("6-9 Timer1", 70);
        PlayerPrefs.SetFloat("6-9 Timer2", 50);
        PlayerPrefs.SetFloat("6-9 Timer3", 40);
        PlayerPrefs.SetInt("hasActivate 6-9", 1);
        PlayerPrefs.SetInt("hasJump 6-9", 0);
        PlayerPrefs.SetInt("hasNug 6-9", 0);

        PlayerPrefs.SetString("6-HiddenTitle", "Be fast, be smart");
        PlayerPrefs.SetFloat("6-Hidden Timer1", 20);
        PlayerPrefs.SetFloat("6-Hidden Timer2", 15);
        PlayerPrefs.SetFloat("6-Hidden Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 6-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 6-Hidden", 1);
        PlayerPrefs.SetInt("hasNug 6-Hidden", 0);

    }

    private void WorldSevenStats()
    {
        PlayerPrefs.SetString("7-1Title", "They move?!");
        PlayerPrefs.SetFloat("7-1 Timer1", 30);
        PlayerPrefs.SetFloat("7-1 Timer2", 15);
        PlayerPrefs.SetFloat("7-1 Timer3", 10);
        PlayerPrefs.SetInt("hasActivate 7-1", 0);
        PlayerPrefs.SetInt("hasJump 7-1", 0);
        PlayerPrefs.SetInt("hasNug 7-1", 0);

        PlayerPrefs.SetString("7-2Title", "All about timing");
        PlayerPrefs.SetFloat("7-2 Timer1", 16);
        PlayerPrefs.SetFloat("7-2 Timer2", 13);
        PlayerPrefs.SetFloat("7-2 Timer3", 8);
        PlayerPrefs.SetInt("hasActivate 7-2", 0);
        PlayerPrefs.SetInt("hasJump 7-2", 0);
        PlayerPrefs.SetInt("hasNug 7-2", 0);

        PlayerPrefs.SetString("7-3Title", "Jump to success");
        PlayerPrefs.SetFloat("7-3 Timer1", 12);
        PlayerPrefs.SetFloat("7-3 Timer2", 8);
        PlayerPrefs.SetFloat("7-3 Timer3", 5);
        PlayerPrefs.SetInt("hasActivate 7-3", 0);
        PlayerPrefs.SetInt("hasJump 7-3", 1);
        PlayerPrefs.SetInt("hasNug 7-3", 0);

        PlayerPrefs.SetString("7-4Title", "Hold on");
        PlayerPrefs.SetFloat("7-4 Timer1", 16);
        PlayerPrefs.SetFloat("7-4 Timer2", 13);
        PlayerPrefs.SetFloat("7-4 Timer3", 11);
        PlayerPrefs.SetInt("hasActivate 7-4", 0);
        PlayerPrefs.SetInt("hasJump 7-4", 0);
        PlayerPrefs.SetInt("hasNug 7-4", 0);

        PlayerPrefs.SetString("7-5Title", "Predict the pattern");
        PlayerPrefs.SetFloat("7-5 Timer1", 16);
        PlayerPrefs.SetFloat("7-5 Timer2", 13);
        PlayerPrefs.SetFloat("7-5 Timer3", 9);
        PlayerPrefs.SetInt("hasActivate 7-5", 0);
        PlayerPrefs.SetInt("hasJump 7-5", 1);
        PlayerPrefs.SetInt("hasNug 7-5", 0);

        PlayerPrefs.SetString("7-6Title", "What is the scorpions problem?");
        PlayerPrefs.SetFloat("7-6 Timer1", 35);
        PlayerPrefs.SetFloat("7-6 Timer2", 25);
        PlayerPrefs.SetFloat("7-6 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 7-6", 1);
        PlayerPrefs.SetInt("hasJump 7-6", 1);
        PlayerPrefs.SetInt("hasNug 7-6", 0);

        PlayerPrefs.SetString("7-7Title", "Don't.. Fall.. Off..");
        PlayerPrefs.SetFloat("7-7 Timer1", 18);
        PlayerPrefs.SetFloat("7-7 Timer2", 15);
        PlayerPrefs.SetFloat("7-7 Timer3", 13);
        PlayerPrefs.SetInt("hasActivate 7-7", 0);
        PlayerPrefs.SetInt("hasJump 7-7", 0);
        PlayerPrefs.SetInt("hasNug 7-7", 1);

        PlayerPrefs.SetString("7-8Title", "Which way around the log?");
        PlayerPrefs.SetFloat("7-8 Timer1", 25);
        PlayerPrefs.SetFloat("7-8 Timer2", 20);
        PlayerPrefs.SetFloat("7-8 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 7-8", 0);
        PlayerPrefs.SetInt("hasJump 7-8", 0);
        PlayerPrefs.SetInt("hasNug 7-8", 0);

        PlayerPrefs.SetString("7-9Title", "Fast decisions");
        PlayerPrefs.SetFloat("7-9 Timer1", 30);
        PlayerPrefs.SetFloat("7-9 Timer2", 25);
        PlayerPrefs.SetFloat("7-9 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 7-9", 0);
        PlayerPrefs.SetInt("hasJump 7-9", 0);
        PlayerPrefs.SetInt("hasNug 7-9", 0);

        PlayerPrefs.SetString("7-HiddenTitle", "Is this even possible 2");
        PlayerPrefs.SetFloat("7-Hidden Timer1", 20);
        PlayerPrefs.SetFloat("7-Hidden Timer2", 16);
        PlayerPrefs.SetFloat("7-Hidden Timer3", 12);
        PlayerPrefs.SetInt("hasActivate 7-Hidden", 0);
        PlayerPrefs.SetInt("hasJump 7-Hidden", 0);
        PlayerPrefs.SetInt("hasNug 7-Hidden", 0);

    }

    private void WorldEightStats()
    {
        PlayerPrefs.SetString("8-1Title", "Are they all lokking at me?");
        PlayerPrefs.SetFloat("8-1 Timer1", 35);
        PlayerPrefs.SetFloat("8-1 Timer2", 25);
        PlayerPrefs.SetFloat("8-1 Timer3", 20);
        PlayerPrefs.SetInt("hasActivate 8-1", 0);
        PlayerPrefs.SetInt("hasJump 8-1", 0);
        PlayerPrefs.SetInt("hasNug 8-1", 0);

        PlayerPrefs.SetString("8-2Title", "Can't go the same way twice");
        PlayerPrefs.SetFloat("8-2 Timer1", 40);
        PlayerPrefs.SetFloat("8-2 Timer2", 35);
        PlayerPrefs.SetFloat("8-2 Timer3", 25);
        PlayerPrefs.SetInt("hasActivate 8-2", 1);
        PlayerPrefs.SetInt("hasJump 8-2", 0);
        PlayerPrefs.SetInt("hasNug 8-2", 0);

        PlayerPrefs.SetString("8-3Title", "Decide the way");
        PlayerPrefs.SetFloat("8-3 Timer1", 60);
        PlayerPrefs.SetFloat("8-3 Timer2", 50);
        PlayerPrefs.SetFloat("8-3 Timer3", 40);
        PlayerPrefs.SetInt("hasActivate 8-3", 1);
        PlayerPrefs.SetInt("hasJump 8-3", 0);
        PlayerPrefs.SetInt("hasNug 8-3", 0);

        PlayerPrefs.SetString("8-4Title", "When do i get off?");
        PlayerPrefs.SetFloat("8-4 Timer1", 20);
        PlayerPrefs.SetFloat("8-4 Timer2", 16);
        PlayerPrefs.SetFloat("8-4 Timer3", 12);
        PlayerPrefs.SetInt("hasActivate 8-4", 0);
        PlayerPrefs.SetInt("hasJump 8-4", 0);
        PlayerPrefs.SetInt("hasNug 8-4", 0);

        PlayerPrefs.SetString("8-5Title", "I'm getting tired of all these scorpions");
        PlayerPrefs.SetFloat("8-5 Timer1", 30);
        PlayerPrefs.SetFloat("8-5 Timer2", 22);
        PlayerPrefs.SetFloat("8-5 Timer3", 17);
        PlayerPrefs.SetInt("hasActivate 8-5", 1);
        PlayerPrefs.SetInt("hasJump 8-5", 0);
        PlayerPrefs.SetInt("hasNug 8-5", 0);

        PlayerPrefs.SetString("8-6Title", "A pond!");
        PlayerPrefs.SetFloat("8-6 Timer1", 20);
        PlayerPrefs.SetFloat("8-6 Timer2", 15);
        PlayerPrefs.SetFloat("8-6 Timer3", 12);
        PlayerPrefs.SetInt("hasActivate 8-6", 0);
        PlayerPrefs.SetInt("hasJump 8-6", 0);
        PlayerPrefs.SetInt("hasNug 8-6", 0);

        PlayerPrefs.SetString("8-7Title", "Shallow waters");
        PlayerPrefs.SetFloat("8-7 Timer1", 40);
        PlayerPrefs.SetFloat("8-7 Timer2", 35);
        PlayerPrefs.SetFloat("8-7 Timer3", 30);
        PlayerPrefs.SetInt("hasActivate 8-7", 1);
        PlayerPrefs.SetInt("hasJump 8-7", 0);
        PlayerPrefs.SetInt("hasNug 8-7", 1);

        PlayerPrefs.SetString("8-8Title", "Jump around");
        PlayerPrefs.SetFloat("8-8 Timer1", 22);
        PlayerPrefs.SetFloat("8-8 Timer2", 18);
        PlayerPrefs.SetFloat("8-8 Timer3", 15);
        PlayerPrefs.SetInt("hasActivate 8-8", 1);
        PlayerPrefs.SetInt("hasJump 8-8", 1);
        PlayerPrefs.SetInt("hasNug 8-8", 0);

        PlayerPrefs.SetString("8-9Title", "Is that a jungle?");
        PlayerPrefs.SetFloat("8-9 Timer1", 16);
        PlayerPrefs.SetFloat("8-9 Timer2", 13);
        PlayerPrefs.SetFloat("8-9 Timer3", 11);
        PlayerPrefs.SetInt("hasActivate 8-9", 0);
        PlayerPrefs.SetInt("hasJump 8-9", 0);
        PlayerPrefs.SetInt("hasNug 8-9", 0);

        PlayerPrefs.SetString("8-HiddenTitle", "Aim for the rocks!");
        PlayerPrefs.SetFloat("8-Hidden Timer1", 30);
        PlayerPrefs.SetFloat("8-Hidden Timer2", 20);
        PlayerPrefs.SetFloat("8-Hidden Timer3", 15);
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
