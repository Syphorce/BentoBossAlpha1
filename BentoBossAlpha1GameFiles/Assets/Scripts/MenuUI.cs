using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
 public void OnPlayButton()
    {//Change "SampleScene" to "Game" when we eventually change the Sample Scene name to Game Scene
        SceneManager.LoadScene("GameSceneMain");

    }
    
 public void OnQuitButton()
    {
        Application.Quit();
    }
}
