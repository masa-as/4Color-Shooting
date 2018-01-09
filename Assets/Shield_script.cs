using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_script : MonoBehaviour {

    public GameObject shield;
    public GameObject Explosion;
    int num=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire3"))
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        num++;
        Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Destroy(other.gameObject);
        Debug.Log("b");
        if (num == 3)
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this);
            Destroy(this.gameObject);

        }
    }
}
