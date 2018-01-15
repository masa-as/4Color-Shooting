using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultHit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int resultHit = StarfighterControl.hit;
        GetComponent<Text>().text = "Miss Shot: " + resultHit.ToString() + " 回";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
