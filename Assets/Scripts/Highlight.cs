using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Color color;
    public Color highlightColor;
    public SpriteRenderer spriteRenderer;
    
    private void OnMouseOver()
    {
        spriteRenderer.color = highlightColor;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = color;
    }
}
