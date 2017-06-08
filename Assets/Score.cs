using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int totalScore;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        totalScore = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore(int addedScore)
    {
        totalScore += addedScore;
        scoreText = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Text>();
        scoreText.text = "Score: " + totalScore;
    }
}
