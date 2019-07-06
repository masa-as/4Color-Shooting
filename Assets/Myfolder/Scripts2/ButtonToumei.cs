using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToumei : MonoBehaviour {

    public GameObject maru;
    public GameObject batu;
    public GameObject sikaku;
    public GameObject sankaku;
    Color alpha = new Color(1, 1, 1, 0.1f);
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            sankaku.GetComponent<Image>().color = alpha;
        }
        else
        {
            sankaku.GetComponent<Image>().color = Color.white;
        }
        if (Input.GetButton("Fire2"))
        {
            maru.GetComponent<Image>().color = alpha;
        }
        else
        {
            maru.GetComponent<Image>().color = Color.white;
        }
        if (Input.GetButton("Fire3"))
        {
            batu.GetComponent<Image>().color = alpha;
        }
        else
        {
            batu.GetComponent<Image>().color = Color.white;
        }
        if (Input.GetButton("Jump"))
        {
            sikaku.GetComponent<Image>().color = alpha;
        }
        else
        {
            sikaku.GetComponent<Image>().color = Color.white;
        }
    }
}
