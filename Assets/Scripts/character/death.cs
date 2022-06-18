using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public static bool ded;
    // Start is called before the first frame update
    void Start()
    {
        ded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("sichtkegel"))
        {
           
            ded = true;
        }
    }

   
    
}
