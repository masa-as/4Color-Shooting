using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int resultScore = ScoreScript.score;
        GetComponent<Text>().text = "Score: " + resultScore.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
