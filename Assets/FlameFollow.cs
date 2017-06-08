using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameFollow : MonoBehaviour {

    private Vector3 direction;
    public GameObject ball;         //Public variable to store a reference to the player game object

    // Use this for initialization
    void Start () {
        transform.position = ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate() { 
        transform.position = ball.transform.position;
    }
}
