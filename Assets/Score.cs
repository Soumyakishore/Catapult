using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int totalScore;
    public Text scoreText;
    public Text ammunitionText;

    int ammunitionLeft;
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

    public void ShowAmmunition(int ballNumber)
    {
        ammunitionLeft = 5 - ballNumber;
        ammunitionText = GameObject.FindGameObjectWithTag("AmmunitionText").GetComponent<Text>();
        ammunitionText.text = "Ammunition left: " + ammunitionLeft;
    }
}
