using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AufzugStart : MonoBehaviour
{
    public GameObject player;

    private void OnMouseDown()
    {
        if(Vector2.Distance(transform.position, player.transform.position) < 4.8f)
        {
            if (Pathfinding.Dialog.dialogAusgeführt == true && Pickup.schraubenzieherAufgenommen == true)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        
        
    }

}
