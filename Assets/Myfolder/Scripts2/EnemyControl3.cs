using UnityEngine;
using System.Collections;

public class EnemyControl3 : EnemyControl
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet3")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
            FindObjectOfType<ScoreScript>().AddPoint(point);
        }
        else if (coll.gameObject.tag == "PlayerBullet2" || coll.gameObject.tag == "PlayerBullet" || coll.gameObject.tag == "PlayerBullet4")
        {
            EnemyControl.miss++;
        }

    }
}