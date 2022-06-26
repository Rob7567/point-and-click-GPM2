using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schacht : MonoBehaviour
{
    public GameObject schachtOb;
    public GameObject player;
    public GameObject dist;
    public GameObject trigger;

    private void OnMouseDown()
    {
        if(Vector2.Distance(dist.transform.position, player.transform.position) < 3.0f)
        {
            schachtOb.SetActive(true);
            gameObject.SetActive(false);
            trigger.SetActive(true);
        }
        
    }
}
