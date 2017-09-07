using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformStick : MonoBehaviour {

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "MovingPlatform" || collision.gameObject.GetComponent<Plate>().TypeNumb == Plate.PlateType.ActivationPlate)
        {
            transform.parent = collision.transform;
        }
        else
        {
            transform.parent = null;
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "MovingPlatform" || collision.gameObject.GetComponent<Plate>().TypeNumb == Plate.PlateType.ActivationPlate)
        {
            transform.parent = null;
        }

    }
}
