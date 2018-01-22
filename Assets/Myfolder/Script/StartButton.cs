using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButton("Start"))
        {
            //ScoreScript.score = 10;
            SceneManager.LoadScene("GameScene01");
        }
    }
}