using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDialog : MonoBehaviour
{
    public SC_ItemCrafting itemCrafting;
    public Pathfinding.Dialog3 dialog3;

    public Sprite sprite;

    public GameObject player;

    public float dist;

    public static bool schraubenzieherAufgenommen = false;
    public static bool artifakt = false;

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
            //dialog3.StartDialogue();
            itemCrafting.currentSprite = sprite;

            itemCrafting.PickupItem();

            Destroy(gameObject);
            audio.Play();

            
                dialog3.DialogStart();
                dialog3.StartDialogue();
            
        }

        if (CompareTag("Schraubenzieher") && dist <= 3.6f)
        {
            schraubenzieherAufgenommen = true;
        }

        if (CompareTag("Artifakt") && dist <= 3.6f)
        {
            artifakt = true;
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
