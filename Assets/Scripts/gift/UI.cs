using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void BackToMenu_btn()
    {
        SceneManager.LoadScene("Menu");
    }
}
