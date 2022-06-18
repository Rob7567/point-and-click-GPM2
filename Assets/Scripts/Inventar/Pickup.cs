using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public SC_ItemCrafting itemCrafting; 

    public Sprite sprite;

    public GameObject player;

    public float dist;

    private void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
    }

    private void OnMouseDown()
    {
        if (dist <= 3.2f)
        {
            itemCrafting.currentSprite = sprite;

            itemCrafting.PickupItem();

            Destroy(gameObject);
        }

        
    }
}
