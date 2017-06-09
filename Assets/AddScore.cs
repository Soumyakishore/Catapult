using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {

    public GameObject pow;
    bool powSpawned = false;
    AudioSource explosion;
    GameObject newPow;

    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(0);
        explosion = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CheckPowSpawn()
    {
        if (powSpawned == false)
        {
            newPow = Instantiate(pow, transform.position, Quaternion.identity);
            powSpawned = true;
            explosion.Play();
            Destroy(newPow, 0.1F);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);

        if (collision.collider.tag == "WallBlock")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(1000);
            //Instantiate(explosion, transform.position, transform.rotation);
            CheckPowSpawn();

        }
        if(collision.collider.tag == "TowerCube")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(5000);
            // Instantiate(explosion, transform.position, transform.rotation);
            CheckPowSpawn();
        }
        if (collision.collider.tag == "Ukkeli")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(50000);
            //  Instantiate(explosion, transform.position, transform.rotation);
            CheckPowSpawn();
        }
        if (collision.collider.tag == "CenterTower")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Score>().UpdateScore(10000);
            // Instantiate(explosion, transform.position, transform.rotation);
            CheckPowSpawn();
        }
    }
}
