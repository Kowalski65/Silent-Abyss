using UnityEngine;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    public Button closeButton;  
    public GameObject panel;    

    void Start()
    {
        
        closeButton.onClick.AddListener(ClosePanel);
    }

    void ClosePanel()
    {
        
        panel.SetActive(false);
    }
}
