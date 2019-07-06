using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public GameObject GameStartBtn;
    public GameObject starFighterPrefab;
    public GameObject GameOverSet;
    public bool gameFlag;
	// Use this for initialization
	void Start () {
        gameFlag = true;	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameFlag == false) {
            SceneManager.LoadScene("gameover");
//            GameOverSet.SetActive(true);
        }	
	}

    public void GameStartButton() {
        Instantiate(starFighterPrefab);
        GameStartBtn.SetActive(false);
    }

    public void GameOverButton() {
        SceneManager.LoadScene("GameScene01");
    }
}
