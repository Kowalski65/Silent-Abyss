using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Button openButton;    
    public GameObject settingsPanel; 

    void Start()
    {
        
        openButton.onClick.AddListener(OpenPanel);
    }

    void OpenPanel()
    {
        
        settingsPanel.SetActive(true);
    }
}
