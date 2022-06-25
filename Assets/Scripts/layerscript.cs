using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerscript : MonoBehaviour
{
    public GameObject player;
    public bool layer;
    public bool invlayer;
    public SpriteRenderer spriterenderer;


    private void Update()
    {
        if (layer == true)
        {
            if (invlayer == true)
            {
                spriterenderer.sortingOrder = -1;
            }
            else
            spriterenderer.sortingOrder = 1;
        }

        if (layer == false)
        {
            spriterenderer.sortingOrder = 3;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("layertrigger"))
        {
            layer = true;
            
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("invlayertrigger"))
        {
            invlayer = true;

        }
    }
        private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("layertrigger"))
        {
            layer = false;
            
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("invlayertrigger"))
        {
            invlayer = false;

        }
    }

}
