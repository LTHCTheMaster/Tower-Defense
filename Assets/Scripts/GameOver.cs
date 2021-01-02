using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string mainMenu = "MainMenu";

    public SceneFader sceneFader;

    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Debug.Log("Menu");
        sceneFader.FadeTo(mainMenu);
    }
}
