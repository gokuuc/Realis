using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    [SerializeField] GameObject Finish_menu;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject Next_Button;

    public static bool finish_level1;
    public static bool finish_level2;
    public static bool finish_level3;

    private void OnTriggerEnter(Collider other)
    {
        Finish_menu.gameObject.SetActive(true);
        UI.gameObject.SetActive(false);

        Time.timeScale = 0;

        if(SceneManager.GetActiveScene().name == "Game")
        {
            finish_level1 = true;
        }
        if (SceneManager.GetActiveScene().name == "Game1")
        {
            finish_level2 = true;
        }
        if (SceneManager.GetActiveScene().name == "Game2")
        {
            finish_level3 = true;
            Next_Button.gameObject.SetActive(false);
        }
    }

    public void next_level()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            SceneManager.LoadScene("Game1");
            Time.timeScale = 1;
        }
        if (SceneManager.GetActiveScene().name == "Game1")
        {
            SceneManager.LoadScene("Game2");
            Time.timeScale = 1;
        }
    }
}
