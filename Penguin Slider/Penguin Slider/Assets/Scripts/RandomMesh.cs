using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMesh : MonoBehaviour {

    private Renderer myRenderer;
    [SerializeField]
    private Material iceMat;
    [SerializeField]
    private Material sandMat;
    [SerializeField]
    private Material jungleMat;
    [SerializeField]
    private int myrandom = 2;

    // Use this for initialization
    void Start () {

        myRenderer = this.GetComponent<Renderer>();
        myRenderer.enabled = true;
        myrandom = Random.Range(0, 2);
        switch (myrandom)
        {
            case 0:
                myRenderer.material = iceMat;
                break;
            case 1:
                myRenderer.material = sandMat;
                break;
            case 2:
                myRenderer.material = jungleMat;
                break;
        }

    }
}
