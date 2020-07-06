using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool gameOver;

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
    }
}
