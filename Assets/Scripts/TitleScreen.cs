using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Startenv");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void TitleScreenLoad()
    {
        SceneManager.LoadScene("Title");
    }

}
