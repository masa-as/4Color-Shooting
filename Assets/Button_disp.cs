using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_disp : MonoBehaviour {

    public Text text;

    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            text.gameObject.SetActive(true);
        }
        if (Input.GetButtonUp("Fire2"))
        {
            text.gameObject.SetActive(false);
        }
    }   
}
