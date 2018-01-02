using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButton("Fire2")||Input.GetKey("x"))
        {
            ScoreScript.score = 0;
            SceneManager.LoadScene("GameScene01");
        }
    }
}