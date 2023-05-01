using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gamehasEnded = false;
    public float restartDelay = 1;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        Debug.Log("WON");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
