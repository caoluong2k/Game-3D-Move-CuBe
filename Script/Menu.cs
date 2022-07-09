using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject OptionPanel;
    public GameObject MenuPanel;
    public GameObject HowToPlayPanel;
    public GameObject PlayGamePanel;

    public Button level02Button, level03Button;
    int levelPassed;


    public void GotoPlayGame()
    {
        PlayGamePanel.SetActive(true);
        MenuPanel.SetActive(false);
        OptionPanel.SetActive(false);
    }

    public void StartGame()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    public void GoToOptionPanel()
    {
        PlayGamePanel.SetActive(false);
        MenuPanel.SetActive(false);
        OptionPanel.SetActive(true);
    }

    public void GoToHowToPlay()
    {
        PlayGamePanel.SetActive(false);
        MenuPanel.SetActive(false);
        HowToPlayPanel.SetActive(true);

    }
    
    public void Back()
    {
        PlayGamePanel.SetActive(false);
        MenuPanel.SetActive(true);
        OptionPanel.SetActive(false);
        HowToPlayPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
