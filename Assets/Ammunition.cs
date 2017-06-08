using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammunition : MonoBehaviour {

    public GameObject ammunitionCounter;
    public Text ammunitionText;
    int ammunitionLeft;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowAmmunition(int ballNumber)
    {
        ammunitionLeft = 5 - ballNumber;
        ammunitionText = GameObject.FindGameObjectWithTag("AmmunitionText").GetComponent<Text>();
        ammunitionText.text = "Ammunition left: " + ammunitionLeft;
    }
}
