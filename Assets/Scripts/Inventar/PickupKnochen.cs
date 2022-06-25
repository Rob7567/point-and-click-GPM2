using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKnochen : MonoBehaviour
{
    public SC_ItemCrafting itemCrafting;

    public Sprite sprite;

    public GameObject player;


    public GameObject table1;
    public GameObject table2;

    public float dist;

    public Color color;
    public Color highlightColor;
    public SpriteRenderer spriteRenderer;

    public AudioSource audio;

    private void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
    }

    private void OnMouseDown()
    {
        if (dist <= 3.6f)
        {
            itemCrafting.currentSprite = sprite;

            itemCrafting.PickupItem();

            table1.SetActive(false);
            table2.SetActive(true);

            Destroy(gameObject);
            audio.Play();
        }

        

    }

    private void OnMouseOver()
    {
        spriteRenderer.color = highlightColor;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = color;
    }
}
