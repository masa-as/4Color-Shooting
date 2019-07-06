using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Start"))
        {
            SceneManager.LoadScene("title");
            TimeScript.time = 0;
        }

    }
}