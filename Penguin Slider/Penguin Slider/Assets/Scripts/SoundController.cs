using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    // define the audio clips
    public AudioClip slide;
    public AudioClip die;
    public AudioClip hitBounce;
    public AudioClip unlockStars;
    public AudioClip celebration;
    public AudioClip activationPlate;
    public AudioClip goalUnlock;
    public AudioClip quicksandGone;
    public AudioClip wallHit;
    public AudioClip jump;
    public AudioClip menuInteraction;
    public AudioClip goldenNug;

    public AudioSource audioSlide;
    public AudioSource audioDie;
    public AudioSource audioHitBounce;
    public AudioSource audioUnlockStars;
    public AudioSource audioCelebration;
    public AudioSource audioActivationPlate;
    public AudioSource audioGoalUnlock;
    public AudioSource audioQuicksandGone;
    public AudioSource audioWallHit;
    public AudioSource audioJump;
    public AudioSource audioMenuInteraction;
    public AudioSource audioGoldenNug;


    public void Awake()
    {
        // add the necessary AudioSources:
        audioSlide = AddAudio(slide, true, false, 2f);
        audioDie = AddAudio(die, false, false, 1f);
        audioHitBounce = AddAudio(hitBounce, false, false, 1f);
        audioUnlockStars = AddAudio(unlockStars, false, false, 1f);
        audioCelebration = AddAudio(celebration, false, false, 0.1f);
        audioActivationPlate = AddAudio(activationPlate, true, false, 1f);
        audioGoalUnlock = AddAudio(goalUnlock, false, false, 1f);
        audioQuicksandGone = AddAudio(quicksandGone, false, false, 1f);
        audioWallHit = AddAudio(wallHit, false, false, 2f);
        audioJump = AddAudio(jump, false, false, 1f);
        audioMenuInteraction = AddAudio(menuInteraction, false, false, 1f);
        audioGoldenNug = AddAudio(goldenNug, false, false, 1f);
    }


    public AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float vol)
    {
        AudioSource newAudio = gameObject.AddComponent<AudioSource>();
        newAudio.clip = clip;
        newAudio.loop = loop;
        newAudio.playOnAwake = playAwake;
        newAudio.volume = vol;
        return newAudio;
    }

    //THIS IS USED TO PLAY THE SOUNDS
    //audioWeapon1.Play();
    //audioEngine.pitch *= curVelocity/maxVelocity;
    //http://answers.unity3d.com/questions/240468/how-to-play-multiple-audioclips-from-the-same-obje.html
}
