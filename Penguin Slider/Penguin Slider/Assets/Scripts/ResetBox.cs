using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetBox : MonoBehaviour {

    private LevelTracker lt;

    private void Awake()
    {
        lt = GameObject.Find("GameTracker").GetComponent<LevelTracker>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            lt.AddDeath();
            GameObject.Find("GameHandler").GetComponent<SoundController>().audioDie.Play();

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
