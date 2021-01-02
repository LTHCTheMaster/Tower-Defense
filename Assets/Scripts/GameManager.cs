using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameIsOver;

    public GameObject gameOverUI;

    public string nextLevel = "Level2";
    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    public GameObject completeLevelUi;

    private void Start()
    {
        gameIsOver = false;
    }

    void Update()
    {
        if(Input.GetKeyDown("l"))
        {
            EndGame();
        }

        if(gameIsOver)
        {
            return;
        }
        if(PlayerStats.lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameIsOver = true;
        completeLevelUi.SetActive(true);
    }
}
