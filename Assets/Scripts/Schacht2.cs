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
            if (SC_ItemCrafting.r�tselBool2 == true && SC_ItemCrafting.r�tselBool3 == false)
            {
                SceneManager.LoadScene("Hangar");
            }

            if (SC_ItemCrafting.r�tselBool3 == true && SC_ItemCrafting.r�tselBool2 == false)
            {
                SceneManager.LoadScene("GameOver2");
            }

            if (SC_ItemCrafting.r�tselBool2 == true && SC_ItemCrafting.r�tselBool3 == true)
            {
                SceneManager.LoadScene("Hangar");
            }
        }
        


    }
}
