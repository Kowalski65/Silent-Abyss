using UnityEngine;
using TMPro;

public class ScreenControl : MonoBehaviour
{
    public TMP_Dropdown screenModeDropdown; 

    void Start()
    {
        
        screenModeDropdown.ClearOptions();
        screenModeDropdown.AddOptions(new System.Collections.Generic.List<string>
        {
            "Full screen",
            "Windowed",
            "Windowed without frame"
        });

        
        screenModeDropdown.onValueChanged.AddListener(ChangeScreenMode);

        
        ChangeScreenMode(screenModeDropdown.value);
    }

    void ChangeScreenMode(int value)
    {
        switch (value)
        {
            case 0:
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
                break;
            case 1:
                Screen.fullScreenMode = FullScreenMode.Windowed;
                break;
            case 2:
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                break;
        }
    }
}
