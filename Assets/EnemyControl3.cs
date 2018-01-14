using UnityEngine;
using System.Collections;

public class EnemyControl3 : MonoBehaviour
{
    public GameObject EnemyBullet;
    public GameObject Explosion;
    float Z_Speed = 0.7f;
    float intervalTime;
    public int point = 1;
    float threshold2 = EnemyControl.getThreshold();

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
        Destroy(this.gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1 * Z_Speed);

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= threshold2)
        {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }

    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet3")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
            FindObjectOfType<ScoreScript>().AddPoint(point);
        }
    }
}