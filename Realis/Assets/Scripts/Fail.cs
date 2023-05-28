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
}
