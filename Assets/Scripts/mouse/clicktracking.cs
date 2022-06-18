using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktracking : MonoBehaviour
{
    
    public GameObject cursor;
    public BoxCollider2D steam;
    public bool onSteam;
    
   


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (rohr.onSteam == false)
        {
            if (Input.GetMouseButton(1))
            {
                cursor.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
       
        
    }
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Steam"))
        {
            onSteam = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Steam"))
        {
            onSteam = false;
        }
    }*/
    
} 
