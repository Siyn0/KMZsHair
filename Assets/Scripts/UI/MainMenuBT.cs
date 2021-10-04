using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBT : MonoBehaviour
{
    public void StartBT()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitBT()
    {
        Application.Quit();
    }
}
