using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    [SerializeField] GameObject Finish_menu;
    [SerializeField] GameObject UI;

    [SerializeField] Player_Movement movement_script;

    public static bool finish_level1;

    private void OnTriggerEnter(Collider other)
    {
        Finish_menu.gameObject.SetActive(true);
        UI.gameObject.SetActive(false);

        movement_script.speed = 0;

        finish_level1 = true;
    }
}
