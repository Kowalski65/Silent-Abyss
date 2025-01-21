using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button exitButton;

    void Start()
    {
        
        exitButton.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {
        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
        Application.Quit(); // ????? ?? ???? ? ?????
#endif
    }
}
