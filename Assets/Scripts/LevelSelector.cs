﻿using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader sceneFader;

    public Button[] levelButtons;

    private string menuName = "MainMenu";

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
}
