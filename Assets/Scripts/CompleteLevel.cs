using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public string mainMenu = "MainMenu";

    public SceneFader sceneFader;

    public string nextLevel = "Level2";
    public int levelToUnlock = 2;

    public void OnEnable()
    {
        if (levelToUnlock > PlayerPrefs.GetInt("levelReached", 1))
        {
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
    }

    public void Continue()
    {
        sceneFader.FadeTo(nextLevel);
    }

    public void Menu()
    {
        Debug.Log("Menu");
        sceneFader.FadeTo(mainMenu);
    }
}
