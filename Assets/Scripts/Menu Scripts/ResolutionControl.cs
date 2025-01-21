using UnityEngine;
using TMPro;

public class ResolutionControl : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown; 
    private Resolution[] availableResolutions; 

    void Start()
    {
        
        GenerateResolutionList();

        
        resolutionDropdown.onValueChanged.AddListener(ChangeResolution);

        
        SetInitialResolution();
    }

    void GenerateResolutionList()
    {
        
        availableResolutions = new Resolution[]
        {
            new Resolution { width = 1920, height = 1080 },
            new Resolution { width = 1600, height = 900 },
            new Resolution { width = 1280, height = 720 },
            new Resolution { width = 980,  height = 720 }
        };

        
        resolutionDropdown.ClearOptions();
        foreach (var res in availableResolutions)
        {
            resolutionDropdown.options.Add(new TMP_Dropdown.OptionData($"{res.width} x {res.height}"));
        }
        resolutionDropdown.RefreshShownValue();
    }

    void SetInitialResolution()
    {
        
        Resolution currentResolution = Screen.currentResolution;
        for (int i = 0; i < availableResolutions.Length; i++)
        {
            if (availableResolutions[i].width == currentResolution.width &&
                availableResolutions[i].height == currentResolution.height)
            {
                resolutionDropdown.value = i;
                break;
            }
        }
    }

    void ChangeResolution(int index)
    {
       
        Resolution selectedResolution = availableResolutions[index];
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, Screen.fullScreenMode);
    }
}
