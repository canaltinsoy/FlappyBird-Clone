using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{


    public bool isDead;
    public float velocity = 1f; 
    public Rigidbody2D theRB;

    public GameManager managerGame;

    public GameObject deathScene;
    
    private void Start() 
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            theRB.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Score")
        {
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            deathScene.SetActive(true);
        }
    }
}
