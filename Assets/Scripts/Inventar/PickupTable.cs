using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTable : MonoBehaviour
{
    public SC_ItemCrafting itemCrafting;

    public Sprite sprite;

    public GameObject player;

    public float dist;

    public GameObject table1;
    public GameObject table2;
    public GameObject table3;
    public GameObject table4;

    public GameObject body;


    /*
    public Color color;
    public Color highlightColor;
    public SpriteRenderer spriteRenderer;
    */

    public AudioSource audio;

    private void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
    }

    private void OnMouseDown()
    {
        if (dist <= 4.6f)
        {
            itemCrafting.currentSprite = sprite;

            itemCrafting.PickupItem();

            table1.SetActive(false);
            table2.SetActive(false);
            table3.SetActive(true);
            table4.SetActive(true);

            audio.Play();
            Destroy(this.gameObject);

            if(body != null)
            {
                body.SetActive(true);
            }
            
        }

        

    }


    /*
    private void OnMouseOver()
    {
        spriteRenderer.color = highlightColor;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = color;
    }*/
}
