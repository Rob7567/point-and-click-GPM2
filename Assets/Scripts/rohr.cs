using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rohr : MonoBehaviour
{
    public static bool onSteam;

    public GameObject steam;

    public GameObject player;
    public float dist;
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

        dist = Vector3.Distance(player.transform.position, transform.position);

    }
    void OnMouseOver()
    {
        onSteam = true;
        
    }
    void OnMouseExit()
    {
        onSteam = false;
    }

    public void OnMouseDown()
    {
        if(SC_ItemCrafting.rätselBool == true)
        {
            if(dist <= 5.0f)
            {
                steam.SetActive(false);
            }
        }
    }

}
