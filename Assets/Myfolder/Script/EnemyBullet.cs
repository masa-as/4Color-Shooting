using UnityEngine;

using System.Collections;

public class EnemyBullet : MonoBehaviour
{

    float bulletSpeed = 2;
    public GameObject Explosion;
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 3);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
            Destroy(this.gameObject);
    }
}