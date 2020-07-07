using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    int highScore;
    Text scoreText;
    int score = 0;

    public Text panelScore;
    public Text panelHighScore;

    // Use this for initialization
    void Start () {
        scoreText = GetComponent<Text>();
        //panelScore = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("HighScore");
        panelHighScore.text = highScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        panelScore.text = score.ToString();

        if (score > highScore)
        {
            highScore = score;
            panelHighScore.text = highScore.ToString();
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
