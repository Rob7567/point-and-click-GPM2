using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rohr : MonoBehaviour
{
    public static bool onSteam;

    public GameObject steam;
    // Start is called before the first frame update
    void Start()
    {
        onSteam = false;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Q))
        {
            steam.SetActive(false);
        }*/
        
    }
    void OnMouseOver()
    {
        onSteam = true;
        
    }
    void OnMouseExit()
    {
        onSteam = false;
    }
}
