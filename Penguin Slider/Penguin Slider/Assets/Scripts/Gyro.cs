using Com.Google.Android.Gms.Games;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum typetorotate { level, ball }
public enum controltype { normal, inverted }

public class Gyro : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody rb;
    //public Transform level;
    [Space(5)]

    [Header("Variables")]
    public typetorotate type;
    public controltype ctrlType;
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

    [Header("PowerUps")]
    public bool inverted;

    private LevelTracker lt;

    public Vector3 counterPos;

    // Use this for initialization
    void Start()
    {
        
        if (GameObject.Find("CalibrateObject") != null)
        {
            counterPos = GameObject.Find("CalibrateObject").GetComponent<CalibrateCounter>().counterPos;
        }
        lt = GameObject.Find("GameTracker").GetComponent<LevelTracker>();
        if (!Input.gyro.enabled)
        {
            Input.gyro.enabled = true;
        }

        if (GetComponent<Rigidbody>() != null)
        {
            rb = GetComponent<Rigidbody>();
            type = typetorotate.ball;
            speed = 23f;
            isGrounded = true;
            jumpForce = 150f;
        }
        else
        {
            type = typetorotate.level;
        }

        if (ctrlType == controltype.inverted)
        {
            inverted = true;
        }
        else
        {
            inverted = false;
        }

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("UI").GetComponent<UI>().Pause();
        }

        if (!lt.gameEnded)
        {
            //This will reset the planes position, so the Y axis is straight (0), does add some "drag" to the game, either make this more smooth, or just use this somehow for movement
            //Quaternion target = Quaternion.Euler(level.rotation.x, 0, level.rotation.y);
            //level.rotation = Quaternion.Slerp(level.rotation, target, Time.deltaTime * smooth);

            switch (type)
            {
                case typetorotate.ball:
                    if (!inverted)
                    {
                        initialOrientationX = -Input.acceleration.y + counterPos.y;
                        initialOrientationY = Input.acceleration.x - counterPos.x;
                    }
                    else
                    {
                        initialOrientationX = -(Input.gyro.rotationRateUnbiased.x - counterPos.x);
                        initialOrientationY = -(Input.gyro.rotationRateUnbiased.y - counterPos.y);
                    }

                    //SÆTTE EN MAX SPEED PÅ HER, SÆTTE MAX TILT OG MIN TILT HØJERE OG LAVERE
                    //SÆTTE MERE ACCELERATION PÅ?

                    initialOrientationY = Mathf.Clamp(initialOrientationY, minYtilt, maxYtilt);
                    initialOrientationX = Mathf.Clamp(initialOrientationX, minXtilt, maxYtilt);
                    rb.AddForce(new Vector3(initialOrientationY * speed, 0.0f, -initialOrientationX * speed));
                    //rb.transform.Translate(initialOrientationY * speed, 0.0f, -initialOrientationX * speed);
                    transform.forward = Vector3.Normalize(new Vector3(Input.acceleration.x * speed, 0f, Input.acceleration.y * speed));

                    //rb.transform.Translate(initialOrientationY * speed, 0.0f, -initialOrientationX * speed);
                    //Debug.DrawRay(rb.transform.position + Vector3.up, Input.acceleration, Color.red);
                    break;

                case typetorotate.level:

                    if (!inverted)
                    {
                        //Using -Input here, so it feels more real, so when you tilt for phone forward, the plane will go forward
                        initialOrientationX = -Input.gyro.rotationRateUnbiased.x * tiltAngle;
                        initialOrientationY = -Input.gyro.rotationRateUnbiased.y * tiltAngle;
                    }
                    else
                    {
                        initialOrientationX = Input.gyro.rotationRateUnbiased.x * tiltAngle;
                        initialOrientationY = Input.gyro.rotationRateUnbiased.y * tiltAngle;
                    }

                    //Rotates the platform according to the gyroscope in the phone
                    //level.Rotate(initialOrientationX / tiltAngle, 0, initialOrientationY / tiltAngle);
                    break;
            }
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (rb.velocity.magnitude > 0)
        {
            if (!GetComponentInChildren<ParticleSystem>().isPlaying)
            {
                GetComponentInChildren<ParticleSystem>().Play();
                GameObject.Find("GameHandler").GetComponent<SoundController>().audioSlide.Play();
            }
        }
        else
        {
            GetComponentInChildren<ParticleSystem>().Stop();
            GameObject.Find("GameHandler").GetComponent<SoundController>().audioSlide.Stop();
            //GetComponentInChildren<ParticleSystem>().Pause();
        }
    }

    public IEnumerator InvertControls()
    {
        inverted ^= true;
        yield return new WaitForSeconds(3);
        inverted ^= true;
    }

    public IEnumerator SpeedUp()
    {
        speed = speed * 3;
        yield return new WaitForSeconds(3);
        speed = speed / 3;
    }

    public IEnumerator InvertPlayer()
    {
        type = typetorotate.level;
        yield return new WaitForSeconds(3);
        type = typetorotate.ball;
    }

    public void Jump()
    {
        Debug.Log("TEST");
        if (isGrounded)
        {
            Debug.Log("JUMP");
            GameObject.Find("GameHandler").GetComponent<SoundController>().audioJump.Play();
            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Wall")
        {
            GetComponent<Animation>().Play();
            Random rnd = new Random();
            int pitch = Random.Range(80, 120);
            GameObject.Find("GameHandler").GetComponent<SoundController>().audioWallHit.pitch = pitch;
            GameObject.Find("GameHandler").GetComponent<SoundController>().audioWallHit.Play();
        }

        if (collision.transform.tag == "Plate" || collision.transform.tag == "MovingPlatform")
        {
            if (!isGrounded)
            {
                isGrounded = true;
            }
        }
    }

}
