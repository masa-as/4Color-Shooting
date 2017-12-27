using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 3);		
	}	
}
