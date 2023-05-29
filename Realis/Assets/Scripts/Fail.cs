using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail : MonoBehaviour
{

    [SerializeField] GameObject Fail_menu;

    private void OnTriggerEnter(Collider other)
    {
        Fail_menu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
        }
        if (SceneManager.GetActiveScene().name == "Game1")
        {
            SceneManager.LoadScene("Game1");
            Time.timeScale = 1;
        }
        if (SceneManager.GetActiveScene().name == "Game2")
        {
            SceneManager.LoadScene("Game2");
            Time.timeScale = 1;
        }
    }
}
