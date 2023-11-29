using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text txtMessage;

    public GameObject restartButton;
    public GameObject exitButton;

    public GameObject homeButtonTop;
    public GameObject restartButtonTop;
    public GameObject stageTitle;
    public GameObject numberTitle;
    public GameObject scoreText;


    public int score = 0;
    public int noOfEnemies;

    public bool isGameRunning = true;
    public bool isLevelCompleted = false;
    public bool ballFell = false;

    public string nextLevel;
    public int levelAt;

    void Start()
    {
        //condition for setting up the level memory
        if(PlayerPrefs.GetInt("p_levelAt") < levelAt)
        {
            PlayerPrefs.SetInt("p_levelAt", levelAt);
        }
        PlayerPrefs.SetInt("p_lastLevel", levelAt);
        PlayerPrefs.Save();

        //end condition for level memory
    }

    void Update()
    {
        print(noOfEnemies);

        if (!isGameRunning)
        {
            restartButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);

            restartButtonTop.gameObject.SetActive(false);
            homeButtonTop.gameObject.SetActive(false);
            stageTitle.gameObject.SetActive(false);
            numberTitle.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(false);
        }

        if (isLevelCompleted)
        {
            txtMessage.text = "Loading next level...";
            Invoke("LoadLevel", 2f);
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
