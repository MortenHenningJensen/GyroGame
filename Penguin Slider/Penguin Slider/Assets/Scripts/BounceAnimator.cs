using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAnimator : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            GetComponent<Animation>().Play();
            GameObject.Find("GameHandler").GetComponent<SoundController>().audioHitBounce.Play();

        }
    }
}
