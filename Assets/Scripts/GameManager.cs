using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static bool gameOver;
    public GameObject GameOverUI;

    public static Vector2 bottomLeft;
    // Use this for initialization

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
    }

    void Start () {
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GameOver()
    {
        gameOver = true;
        GameOverUI.SetActive(true);
    }
    public void OkBtnPressed()
    {
        SceneManager.LoadScene(0);
    }
}
