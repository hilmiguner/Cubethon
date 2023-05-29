using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameEnded = false;
    public float gameEndingDelay;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame() 
    {
        if(!isGameEnded)
        {
            isGameEnded = true;
            Debug.Log("Game over!");
            Invoke("RestartGame", gameEndingDelay);
        }   
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
