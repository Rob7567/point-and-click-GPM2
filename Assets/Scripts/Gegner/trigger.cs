using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    //public bool inRange;
    public static bool canMove;
    public Transform[] player;
    public SpriteRenderer spriteRenderer;
    public AudioSource audio;

    public Color color;
    public Color highlightColor;
    
    // Start is called before the first frame update
    void Start()
    {
        //inRange = false;
        canMove = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Vector2.Distance(transform.position, player[1].position) < 1.8f )
        {
            if (Input.GetKey(KeyCode.Q))
            {
                canMove = true;
            }

        }
        */

        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            canMove = true;
        }
        */

    }

    private void OnMouseDown()
    {
        if (Vector2.Distance(transform.position, player[1].position) < 2.8f)
        {
            if(Pickup.schraubenzieherAufgenommen == true)
            {
                canMove = true;
                audio.Play();
            }
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
