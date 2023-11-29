using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject gameOverTrigger;

    public AudioSource audioSource;

    public Text txtMessage;
    public Text scoreText;

    public float baseHealth;
    public float health;

    public SpriteRenderer slimeSprite;

    void Start()
    {
        health = baseHealth; //slime's health
        slimeSprite = GetComponent<SpriteRenderer>();
        scoreText.text = "SCORE:\n" + gameManager.score;
    }


    public void OnCollisionEnter2D(Collision2D actor)
    {
        //the enemy will die if hit with a velocity.magnitude greater than 5,
        //this is the player's projectile velocity 
        if (actor.relativeVelocity.magnitude >= health)
        {
            Die();
            audioSource.Play();
        }

        else
        {
            health /= 2;
        }
    }

    void Die()
    {
        gameManager.noOfEnemies--; //subtract number of enemies
        Destroy(this.gameObject);

        if (baseHealth == 20)
        {
            gameManager.score += 1000;
        }
        else if (baseHealth == 60)
        {
            gameManager.score += 5000;
        }
        else if (baseHealth == 100)
        {
            gameManager.score += 10000;
        }

        scoreText.text = "SCORE:\n" + gameManager.score;

        if (gameManager.noOfEnemies <= 0)
        {
            gameManager.isLevelCompleted = true;
            gameOverTrigger.gameObject.SetActive(false);
        }
    }
}
