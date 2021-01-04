using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public SceneFader sceneFader;

    public Button[] levelButtons;

    private string menuName = "MainMenu";

    private int keyCount = 0;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }

        keyCount = 0;
    }

    public void Select(string levelName)
    {
        sceneFader.FadeTo(levelName);
    }

    public void ResetLevelProgress()
    {
        PlayerPrefs.DeleteKey("levelReached");
        sceneFader.FadeTo(menuName);
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuName);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && keyCount == 0)
        {
            keyCount = 1;
            return;
        }
        if (Input.GetKeyDown(KeyCode.G) && keyCount == 1)
        {
            keyCount = 2;
        }
        if (Input.GetKeyDown(KeyCode.H) && keyCount == 2)
        {
            keyCount = 3;
            return;
        }
        if (Input.GetKeyDown(KeyCode.H) && keyCount == 3)
        {
            keyCount = 4;
        }
        if (Input.GetKeyDown(KeyCode.J) && keyCount == 4)
        {
            keyCount = 5;
            return;
        }
        if (Input.GetKeyDown(KeyCode.J) && keyCount == 5)
        {
            PlayerPrefs.SetInt("levelReached", 999999);
            sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        }
    }
}
