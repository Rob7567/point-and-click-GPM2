using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktracking : MonoBehaviour
{
    
    public GameObject cursor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            cursor.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
