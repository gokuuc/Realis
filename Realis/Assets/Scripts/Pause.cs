using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    [SerializeField] GameObject pausebutton;

    public void pause()
    {
        pausebutton.gameObject.SetActive(false);
        pausemenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void resume()
    {
        pausebutton.gameObject.SetActive(true);
        pausemenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
