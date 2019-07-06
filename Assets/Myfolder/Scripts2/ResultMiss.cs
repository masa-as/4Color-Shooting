using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultMiss : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int resultMiss = EnemyControl.miss;
        GetComponent<Text>().text = "Miss Shot: " + resultMiss.ToString() + " 回";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
