using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Threading;

public class StarfighterControl : MonoBehaviour
{

    float X_Speed = 1;
    float Y_Speed = 1;

    public GameObject Prefab;
    public GameObject EnemyObject;
    public GameObject Explosion;
    public GameObject maincamera;
    public Text Bbutton;


    float intervalTime;
    float enemyintervalTime;

    // Use this for initialization
    void Start(){
        intervalTime = 0;
        enemyintervalTime = 0;
    }

    // Update is called once per frame
    void Update(){

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(0, vertical * Y_Speed, 0);
        transform.Translate(horizontal * X_Speed, 0, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("a");

        }

        /*
        if (Input.GetKey("up")){
            transform.Translate(0, vertical * Y_Speed, 0);
        }
        if (Input.GetKey("down")){
            transform.Translate(0, vertical * Y_Speed, 0);
        }
        if (Input.GetKey("left")){
            transform.Translate(horizontal * X_Speed, 0, 0);
        }
        if (Input.GetKey("right")){
            transform.Translate(horizontal * X_Speed, 0, 0);
        }
        */
        intervalTime += Time.deltaTime;
        if (Input.GetButton("Fire2")){
            if (intervalTime >= 0.1f){
                intervalTime = 0.0f;
//                gameObject.color = new Color(0, 0, 0, 1.0f);
//                Debug.Log("aa");
                Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        enemyintervalTime += Time.deltaTime;
        if (enemyintervalTime >= 1.0f){
            enemyintervalTime = 0;
            Instantiate(EnemyObject, new Vector3(Random.Range(-35.0f, 35.0f), transform.position.y, transform.position.z + 200), quat);
        }

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(transform.position.x, -35, 35);
        pos.y = Mathf.Clamp(transform.position.y, -15, 15);

        transform.position = pos;
       
    }
    void OnTriggerEnter(Collider coll) {
        if(coll.gameObject.tag == "EnemyBullet"){
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            maincamera.SetActive(true);
            Destroy(this.gameObject);
            SceneManager.LoadScene("gameover");
            //            GameObject.Find("Main Camera").GetComponent<GameControl>().gameFlag = false;
        }
    }
}