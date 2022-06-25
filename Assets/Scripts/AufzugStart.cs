using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AufzugStart : MonoBehaviour
{

    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
