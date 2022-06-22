using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{

    public GameObject trigger;
    public GameObject player;
    public GameObject enemy;

    public Animator animator;

    public AudioSource audioTürauf;
    public AudioSource audioTürzu;

    // Update is called once per frame
    void Update()
    {


        if (Vector2.Distance(player.transform.position, trigger.transform.position) < 2.2f || Vector2.Distance(enemy.transform.position, trigger.transform.position) < 2.2f)
        {
            animator.SetBool("openDoor", true);
        }
        else
        {
            animator.SetBool("openDoor", false);
        }

        if (Vector2.Distance(player.transform.position, trigger.transform.position) > 2.2f && Vector2.Distance(enemy.transform.position, trigger.transform.position) > 2.2f)
        {
            animator.SetBool("closeDoor", true);
        }
        else
        {
            animator.SetBool("closeDoor", false);
        }

        //Enemy
        /*if (Vector2.Distance(enemy.transform.position, trigger.transform.position) < 2.2f)
        {
            animator.SetBool("openDoor", true);
        }
        
        
        if (Vector2.Distance(enemy.transform.position, trigger.transform.position) > 2.2f)
        {
            animator.SetBool("closeDoor", true);
        }*/

        

    }
}
