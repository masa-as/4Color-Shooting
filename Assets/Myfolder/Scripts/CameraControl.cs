using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    public Vector3 difference;
    float differenceX;

    // Use this for initialization
    void Start()
    {

        difference = GameObject.Find("SciFi_Fighter_AK5(Clone)").transform.localPosition;
        differenceX = difference.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("SciFi_Fighter_AK5(Clone)") == true)
        {
            Vector3 startVec = GameObject.Find("SciFi_Fighter_AK5(Clone)").transform.localPosition;
            transform.localPosition = new Vector3(differenceX, startVec.y + difference.y, startVec.z + difference.z);
        }

    }
}