using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private bool movingLeft = true;
    public SpriteRenderer spriteRenderer;
    float old_pos;

    // Update is called once per frame
    void Update()
    {
        if (old_pos < transform.position.x)
        {
            spriteRenderer.flipX = false;
            //print("moving right");
        }
        if (old_pos > transform.position.x)
        {
            spriteRenderer.flipX = true;
            //print("moving left");
        }
        old_pos = transform.position.x;
    }

    void Start()
    {
        old_pos = transform.position.x;
    }
}
