using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Level WON !!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            //Restart();
        }   
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
/*
    public void GameOver()
    {
        Debug.Log("Game Over !");
        completeLevelUI.SetActive(true);
    }
*/
}
