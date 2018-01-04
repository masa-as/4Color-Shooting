using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_disp : MonoBehaviour {

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2")||Input.GetKey("z"))
        {
            a.SetActive(true);
        }
        else
        {
            a.SetActive(false);
        }
        if (Input.GetButton("Fire3"))
        {
            b.SetActive(true);
        }
        else
        {
            b.SetActive(false);
        }
        if (Input.GetButton("Jump"))
        {
            c.SetActive(true);
        }
        else
        {
            c.SetActive(false);
        }
        if (Input.GetButton("Fire1"))
        {
            d.SetActive(true);
        }
        else
        {
            d.SetActive(false);
        }
    }
}
