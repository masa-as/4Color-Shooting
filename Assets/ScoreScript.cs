using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    public static int score = 30;

    void Start()
    {
        GetComponent<Text>().text = "残り: " + score.ToString();
    }
    public void AddPoint(int point)
    {
        score = score - point;
        GetComponent<Text>().text = "残り: " + score.ToString()+" 体";
        if (score <= 0)
        {
            StartCoroutine("GameOver");
        }
    }
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("gameover");
    }

}