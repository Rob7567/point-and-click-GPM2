using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusikZerstörer : MonoBehaviour
{
    
    void Update()
    {
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GameOver"))
        {
            Destroy(this.gameObject);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Hangar"))
        {
            Destroy(this.gameObject);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Title"))
        {
            Destroy(this.gameObject);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Ende"))
        {
            Destroy(this.gameObject);
        }

    }
}
