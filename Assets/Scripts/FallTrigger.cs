using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public bool isGameRunning;

    public void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.CompareTag("Ball"))
        {
            gameManager.ballFell = true;
        }
    }
}
