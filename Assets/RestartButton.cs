using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButton("Fire3"))
        {
            ScoreScript.score = 0;
            SceneManager.LoadScene("GameScene01");
        }

    }

    public void ToMain()
    {
        ScoreScript.score = 0;
        SceneManager.LoadScene("GameScene01");
    }
}