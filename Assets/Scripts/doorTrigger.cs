using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{

    public GameObject trigger;
    public GameObject player;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, trigger.transform.position) < 2.2f)
        {
            animator.SetBool("openDoor",true);
        }
        else
        {
            animator.SetBool("openDoor", false);
        }
       
        if (Vector2.Distance(player.transform.position, trigger.transform.position) > 2.2f)
        {
            animator.SetBool("closeDoor", true);
        }
        else
        {
            animator.SetBool("closeDoor", false);
        }
    }
}
