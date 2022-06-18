using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousepos : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public BoxCollider2D steam;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            
        }
    }
    
}
