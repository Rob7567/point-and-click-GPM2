using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerscript : MonoBehaviour
{
    public GameObject player;
    public bool layer;
    public bool invlayer;
    public SpriteRenderer spriterenderer;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("layertrigger"))
        {
            layer = true;
            
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("invlayertrigger"))
        {
            invlayer = true;
            spriterenderer.sortingOrder = -1;
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
            spriterenderer.sortingOrder = 1;
        }
    }
    public void Update()
    {
        if (layer == true)
        {
            spriterenderer.sortingOrder = 1;
        }
        if (layer == false )
        {
            if (invlayer == true)
            {
                spriterenderer.sortingOrder = -1;
            }
            else
            {
                spriterenderer.sortingOrder = 3;
            }
            
        }
    }

}
