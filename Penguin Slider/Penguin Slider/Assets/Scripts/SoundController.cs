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

    private AudioSource audioSlide;
    private AudioSource audioDie;
    private AudioSource audioHitBounce;
    private AudioSource audioUnlockStars;
    private AudioSource audioCelebration;
    private AudioSource audioActivationPlate;
    private AudioSource audioGoalUnlock;
    private AudioSource audioQuicksandGone;
    private AudioSource audioWallHit;
    private AudioSource audioJump;

    public void Awake()
    {
        // add the necessary AudioSources:
        audioSlide = AddAudio(slide, true, true, 0.2f);
        audioDie = AddAudio(die, true, true, 0.4f);
        audioHitBounce = AddAudio(hitBounce, false, false, 0.8f);
        audioUnlockStars = AddAudio(unlockStars, false, false, 0.8f);
        audioCelebration = AddAudio(slide, true, true, 0.2f);
        audioActivationPlate = AddAudio(die, true, true, 0.4f);
        audioGoalUnlock = AddAudio(hitBounce, false, false, 0.8f);
        audioQuicksandGone = AddAudio(unlockStars, false, false, 0.8f);
        audioWallHit = AddAudio(slide, true, true, 0.2f);
        audioJump = AddAudio(die, true, true, 0.4f);
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
