using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
