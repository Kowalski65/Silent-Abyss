using UnityEngine;
using TMPro;

public class FPSettings : MonoBehaviour
{
    public TMP_Dropdown fpsDropdown; 

    void Start()
    {
        
        fpsDropdown.ClearOptions();
        fpsDropdown.AddOptions(new System.Collections.Generic.List<string>
        {
            "30 FPS",
            "60 FPS",
            "120 FPS",
            "No limit"
        });

        
        fpsDropdown.onValueChanged.AddListener(ChangeFPS);

       
        ChangeFPS(fpsDropdown.value);
    }

    void ChangeFPS(int value)
    {
        switch (value)
        {
            case 0:
                Application.targetFrameRate = 30;
                break;
            case 1:
                Application.targetFrameRate = 60;
                break;
            case 2:
                Application.targetFrameRate = 120;
                break;
            case 3:
                Application.targetFrameRate = -1; 
                break;
        }
    }
}
