using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public static LevelControl instance = null;
    GameObject LevelSign, GameOverText, LevelCompleteText;
    int sceneIndex, levelPassed;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        LevelSign = GameObject.Find("LevelNumberText");
        GameOverText = GameObject.Find("GameOverText");
        LevelCompleteText = GameObject.Find("LevelCompleteText");
        GameOverText.gameObject.SetActive(false);
        LevelCompleteText.gameObject.SetActive(false);

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LEVEL PASSED");

    }


    public void youWin()
    {
        if (sceneIndex == 3)
            Invoke("LOAD MAINMENU", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("LEVEL PASSED", sceneIndex);
            LevelSign.gameObject.SetActive(false);
            LevelCompleteText.gameObject.SetActive(true);
            Invoke ("LOAD NEXT LEVEL", 1f);
        }
    }

    public void youLose()
    {
        LevelSign.gameObject.SetActive(false);
        GameOverText.gameObject.SetActive(true);
        Invoke("LOAD MAINMENU", 1f);
    }

    void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

   void loadMainMenu()
    {
        SceneManager.LoadScene("MAIN MENU");
    }


}
