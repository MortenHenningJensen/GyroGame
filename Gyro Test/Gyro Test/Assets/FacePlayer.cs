using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {

    public Transform lookTarget;
    private int damping;

	// Use this for initialization
	void Start () {
        damping = 4;
        lookTarget = GameObject.FindGameObjectWithTag("Ball").transform;
	}
	
	// Update is called once per frame
	void Update () {
        var lookPos = lookTarget.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }
}
