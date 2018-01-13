using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour
{
    public GameObject EnemyBullet;
    public GameObject Explosion;
    public static float threshold = 1.0f;
    float Z_Speed = 0.7f;
    float intervalTime;
    public int point = 1;
    Quaternion quat = Quaternion.Euler(0, 180, 0);

    public static float getThreshold()
    {
        return threshold;
    }

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
        Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        Destroy(this.gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1 * Z_Speed);


        intervalTime += Time.deltaTime;
        if (intervalTime >= threshold)
        {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }

    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
            FindObjectOfType<ScoreScript>().AddPoint(point);
        }
    }
}