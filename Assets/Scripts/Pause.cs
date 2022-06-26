using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject fortsetzen;
    public GameObject title;
    public GameObject pause;

    public GameObject click;

    public static bool pausegedrückt;

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Einblenden()
    {
        fortsetzen.SetActive(true);
        title.SetActive(true);
        pause.SetActive(false);
        pausegedrückt = true;

        StopAllAudio();
    }

    public void Ausblenden()
    {
        fortsetzen.SetActive(false);
        title.SetActive(false);
        pause.SetActive(true);
        pausegedrückt = false;
        StopAllAudio();
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }

    public AudioSource[] allAudioSources;

    void StopAllAudio()
    {
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.enabled = !audioS.enabled;
        }
    }

}
