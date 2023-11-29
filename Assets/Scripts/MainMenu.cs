using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int levelAt;
    public int lastLevel;

    public int buttonID;

    public Button resumeButton;

    private void Start()
    {
        levelAt = PlayerPrefs.GetInt("p_levelAt");
        lastLevel = PlayerPrefs.GetInt("p_lastLevel");
        if(levelAt > 0)
        {
            resumeButton.interactable = true;
        }
        else
        {
            resumeButton.interactable = false;
        }
    }

    public void BtnStart()
    {
        SceneManager.LoadScene("LevelSelect");

    }

    public void BtnLoadLast()
    {
        SceneManager.LoadScene("Level" + lastLevel);
    }

    public void BtnLoadLevel()
    {
        SceneManager.LoadScene("Level" + buttonID);
    }

    public void BtnReset()
    {
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.SetInt("p_levelAt", 0);
        PlayerPrefs.SetInt("p_lastLevel", 0);
        PlayerPrefs.Save();
    }

    public void BtnQuit()
    {
        Application.Quit();
    }

    public void BtnBackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
