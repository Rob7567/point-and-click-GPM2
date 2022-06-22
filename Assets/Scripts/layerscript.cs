using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerscript : MonoBehaviour
{
    public GameObject player;
    public bool test;
    public SpriteRenderer spriterenderer;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("layertrigger"))
        {
            test = true;
            spriterenderer.sortingOrder = 1;
        }
    }
        private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("layertrigger"))
        {
            test = true;
            spriterenderer.sortingOrder = 3;
        }
    }

}
