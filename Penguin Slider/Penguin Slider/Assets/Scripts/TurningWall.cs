using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningWall : MonoBehaviour
{

    [SerializeField]
    int rotationspeed;

    private LevelTracker lt;

    // Use this for initialization
    void Start()
    {
        lt = GameObject.Find("GameTracker").GetComponent<LevelTracker>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!lt.gameEnded)
        {
            transform.Rotate(0, rotationspeed * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
        }
    }
}
