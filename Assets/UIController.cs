using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.SetParent(GameObject.Find("Camera (eye)").transform);
        transform.localPosition = new Vector3(0, 0, 5);
        transform.rotation = Quaternion.identity;        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
