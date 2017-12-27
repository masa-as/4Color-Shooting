using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimeScript : MonoBehaviour
{
    private float time = 30;
    //********** 追記 **********// 
    public GameObject GameOverSet;
    //********** 追記 **********// 

    void Start()
    {
        GetComponent<Text>().text = "Time: " + ((int)time).ToString();
    }

    void Update()
    {
        time -= Time.deltaTime;
        //********** 追記 **********// 
        if (time < 0)
        {
            StartCoroutine("GameOver");
        }
        //********** 追記 **********// 
        if (time < 0) time = 0;
        GetComponent<Text>().text = "Time: " + ((int)time).ToString();
    }
    //********** 追記 **********// 
    IEnumerator GameOver()
    {
        SceneManager.LoadScene("gameover");
        yield return new WaitForSeconds(2.0f);
    }
    //********** 追記 **********// 
}