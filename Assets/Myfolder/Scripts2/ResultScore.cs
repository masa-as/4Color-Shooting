using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int resultTime = (int)TimeScript.time;
        GetComponent<Text>().text = "Time: " + resultTime.ToString()+" 秒";
        Debug.Log(EnemyControl.miss);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
