using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour
{
    public SceneFader sceneFader;
    public string menuName;

    public void Menu()
    {
        sceneFader.FadeTo(menuName);
    }
}
