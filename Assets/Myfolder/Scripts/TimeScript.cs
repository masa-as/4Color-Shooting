using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimeScript : MonoBehaviour
{
    public static float time = 0;
    public GameObject GameOverSet;

    void Start()
    {
        GetComponent<Text>().text = "Time: " + ((int)time).ToString();
    }

    void Update()
    {
        time += Time.deltaTime;
        GetComponent<Text>().text = "Time: " + ((int)time).ToString()+" 秒";
    }
}