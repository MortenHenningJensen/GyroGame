using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPenguinController : MonoBehaviour
{

    [Header("Components")]
    public Rigidbody rb;
    //public Transform level;
    [Space(5)]

    [Header("Phone Variables")]
    public float initialOrientationX;
    public float initialOrientationY;
    public float minXtilt = -50;
    public float maxXtilt = 50;
    public float minYtilt = -50;
    public float maxYtilt = 50;
    [Range(0.1f, 2f)]
    public float smooth = 0.5F;
    public float tiltAngle = 30.0F;
    [Range(5, 100)]
    public float speed;
    public float jumpForce;
    public bool isGrounded;
    [Space(5)]

    public Vector3 counterPos;

    // Use this for initialization
    void Start()
    {
        if (!Input.gyro.enabled)
        {
            Input.gyro.enabled = true;
        }

        if (GetComponent<Rigidbody>() != null)
        {
            rb = GetComponent<Rigidbody>();
            speed = 22f;
            isGrounded = true;
            jumpForce = 150f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        initialOrientationX = -(Input.gyro.rotationRateUnbiased.x - counterPos.x);
        initialOrientationY = -(Input.gyro.rotationRateUnbiased.y - counterPos.y);

        initialOrientationY = Mathf.Clamp(initialOrientationY, minYtilt, maxYtilt);
        initialOrientationX = Mathf.Clamp(initialOrientationX, minXtilt, maxYtilt);
        rb.AddForce(new Vector3(initialOrientationY * speed, 0.0f, -initialOrientationX * speed));
        //rb.transform.Translate(initialOrientationY * speed, 0.0f, -initialOrientationX * speed);
        transform.forward = Vector3.Normalize(new Vector3(Input.acceleration.x * speed, 0f, Input.acceleration.y * speed));

        if (rb.velocity.magnitude > 0)
        {
            GetComponentInChildren<ParticleSystem>().Play();
        }
        else
        {
            //GetComponentInChildren<ParticleSystem>().Stop();
            GetComponentInChildren<ParticleSystem>().Pause();
        }

    }
}
