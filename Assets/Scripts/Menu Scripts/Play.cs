using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    void Start()
    {

        Button PlayButton = GameObject.Find("Play").GetComponent<Button>();


        if (PlayButton != null)
        {
            PlayButton.onClick.AddListener(LoadMainGame);
        }
        
    }


    void LoadMainGame()
    {

        SceneManager.LoadScene("Level");
    }
}
