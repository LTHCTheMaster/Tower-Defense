using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text livesText;
    
    void Update()
    {
        livesText.text = PlayerStats.lives + " LIVES";
    }
}
