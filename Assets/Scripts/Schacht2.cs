using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Schacht2 : MonoBehaviour
{
    public GameObject player;
    public GameObject dist;

    private void OnMouseDown()
    {
        if(Vector2.Distance(dist.transform.position, player.transform.position) < 4.0f)
        {
            if (SC_ItemCrafting.rätselBool2 == true && SC_ItemCrafting.rätselBool3 == false)
            {
                SceneManager.LoadScene("Hangar");
            }

            if (SC_ItemCrafting.rätselBool3 == true && SC_ItemCrafting.rätselBool2 == false)
            {
                SceneManager.LoadScene("GameOver2");
            }

            if (SC_ItemCrafting.rätselBool2 == true && SC_ItemCrafting.rätselBool3 == true)
            {
                SceneManager.LoadScene("Hangar");
            }
        }
        


    }
}
