using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            ScoreScript.score = 30;
            EnemyControl.miss = 0;
            TimeScript.time = 0;
            SceneManager.LoadScene("GameScene01");
        }

    }
}