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
        if(Finish.finish_level1 == false)
        {
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
            Fail_Scene.gameObject.SetActive(false);
        }
    }
    public void Level2()
    {
        if (Finish.finish_level2 == false && Finish.finish_level1 == true)
        {
            SceneManager.LoadScene("Game1");
            Time.timeScale = 1;
            Fail_Scene.gameObject.SetActive(false);
        }
    }
    public void Level3()
    {
        if (Finish.finish_level3 == false && Finish.finish_level2 == true)
        {
            SceneManager.LoadScene("Game2");
            Time.timeScale = 1;
            Fail_Scene.gameObject.SetActive(false);
        }
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
        if (Finish.finish_level2 == true)
        {
            Level2_Button.GetComponent<Image>().color = Color.green;
            Level3_Button.GetComponent<Image>().color = Color.white;
        }
        if (Finish.finish_level3 == true)
        {
            Level3_Button.GetComponent<Image>().color = Color.green;
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
