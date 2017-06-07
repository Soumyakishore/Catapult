using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    public GameObject ball;         //Public variable to store a reference to the player game object

    // Use this for initialization
    void Start () {
        offset = transform.position - ball.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = ball.transform.position + offset;
    }

    public void ResetCamera(GameObject gameObject)
    {
        ball = gameObject;
    }
}
