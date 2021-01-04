using UnityEngine;

public class SecretInfoMenu : MonoBehaviour
{
    public string secretInfoMenuName;
    public SceneFader sceneFader;
    private int keyCount = 0;

    private void Start()
    {
        keyCount = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && keyCount == 0)
        {
            keyCount = 1;
        }
        if (Input.GetKeyDown(KeyCode.H) && keyCount == 1)
        {
            keyCount = 2;
        }
        if (Input.GetKeyDown(KeyCode.J) && keyCount == 2)
        {
            sceneFader.FadeTo(secretInfoMenuName);
            keyCount = 0;
        }
    }
}
