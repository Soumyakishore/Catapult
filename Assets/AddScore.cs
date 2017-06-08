using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {


    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        
        if(collision.collider.tag == "WallBlock")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(100);
        }
        if(collision.collider.tag == "TowerCube")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(500);
        }
        if (collision.collider.tag == "Ukkeli")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(5000);
        }
        if (collision.collider.tag == "CenterTower")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(1000);
        }
    }
}
