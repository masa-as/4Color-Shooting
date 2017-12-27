﻿using UnityEngine;

using System.Collections;

public class MyBullet : MonoBehaviour
{

    float bulletSpeed = 2;
    public GameObject scoreGUI;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 5);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
    }
    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Enemy")
        Destroy(this.gameObject);
    }
}