using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource audioSource;  
    public Scrollbar volumeScrollbar; 

    void Start()
    {
        
        audioSource.volume = volumeScrollbar.value;

        
        volumeScrollbar.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float value)
    {
        
        audioSource.volume = value;
    }
}
