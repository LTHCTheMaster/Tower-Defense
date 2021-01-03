using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainScene";
    public SceneFader sceneFader;

    public string infoMenuName;

    public void Play()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void InfoMenu()
    {
        sceneFader.FadeTo(infoMenuName);
    }
}
