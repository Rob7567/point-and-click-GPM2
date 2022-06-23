using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicktracking : MonoBehaviour
{
    
    public GameObject cursor;
    public BoxCollider2D steam;
    public bool onSteam;

    public Animator animator;
    public GameObject player;
   


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

            if (Input.GetMouseButtonDown(1))
            {
                
                animator.SetBool("click", true);
            }
            
        }
        /*if (Vector2.Distance(transform.position, player.transform.position) < 0.5f)
        {
            animator.SetBool("walking", false);
        }
        else
        {
            animator.SetBool("walking", true);
        }*/


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
