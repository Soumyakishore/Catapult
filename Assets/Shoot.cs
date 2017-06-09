using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{

    Rigidbody ammunition;
    public Rigidbody rb;
    GameObject cupGraphic;
    GameObject ball;
    float StartTime;
    float End;
    float force = 3000.0f;
    public Animator launchAnim;
    Vector3 cupPosition;
    public int ballNumber = 0;

    public Text ammunitionText;
    int ammunitionLeft;

    public float SpawnTime = 5.0f;

    // Use this for initialization
    void Start()
    {
        launchAnim = GetComponent<Animator>();
        rb.GetComponent<Score>().ShowAmmunition(0);
    }

    // Update is called once per frame
    void Update()
    {
        // when space is pressed down the counter starts
        if (Input.GetKeyDown(KeyCode.Space))
           {
                Launch();
           }
    }

    public void Launch()
    {
        launchAnim.SetTrigger("Shoot");
        ballNumber += 1;
        Invoke("SpawnAmmunition", SpawnTime);
    }

    // Animaattorin keskivaiheilla
    public void ShootCow()
    {
        rb.AddForce(-transform.forward * force + Vector3.up * force/2, ForceMode.Impulse);

    }

    // Animaattorin lopussa
    public void SpawnAmmunition()
    {
        if (ballNumber < 5)
        {
            cupGraphic = GameObject.FindGameObjectWithTag("Respawn");
            cupPosition = cupGraphic.gameObject.transform.position;
            Rigidbody ammunition = (Rigidbody)Instantiate(rb, cupPosition, transform.rotation);
            rb = ammunition;
            rb.velocity = new Vector3(0, 0, 0);
            rb.transform.position = new Vector3(cupPosition.x, (cupPosition.y + 0.5f), cupPosition.z);

            //CameraFollow cameraFollow = gameObject.GetComponent<CameraFollow>();
            ball = rb.gameObject;
            ball.GetComponent<Score>().ShowAmmunition(ballNumber);
            Camera.main.GetComponent<CameraFollow>().ResetCamera(ball);
            //cameraFollow.ResetCamera(ball);
        } else
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
