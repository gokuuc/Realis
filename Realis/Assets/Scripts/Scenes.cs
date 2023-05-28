using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{

    [SerializeField] GameObject Levels;
    [SerializeField] GameObject MainMenu_B;
    [SerializeField] GameObject Fail_Scene;

    [SerializeField] GameObject Level1_Button;
    [SerializeField] GameObject Level2_Button;
    [SerializeField] GameObject Level3_Button;

    public void Level1()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        Fail_Scene.gameObject.SetActive(false);
    }
    public void Level2()
    {
        SceneManager.LoadScene("Game1");
        Time.timeScale = 1;
        Fail_Scene.gameObject.SetActive(false);
    }
    public void Level3()
    {
        SceneManager.LoadScene("Game2");
        Time.timeScale = 1;
        Fail_Scene.gameObject.SetActive(false);
    }
    public void LevelMenu()
    {
        Levels.gameObject.SetActive(true);
        MainMenu_B.gameObject.SetActive(false);

        if(Finish.finish_level1 == true)
        {
            Level1_Button.GetComponent<Image>().color = Color.green;
            Level2_Button.GetComponent<Image>().color = Color.white;
        }
    }
    public void MainMenu()
    {
        Levels.gameObject.SetActive(false);
        MainMenu_B.gameObject.SetActive(true);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
