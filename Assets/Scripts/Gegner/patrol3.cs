using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol3 : MonoBehaviour
{

    public GameObject ziel;

    public int counter;
    public Transform[] moveSpots;
    public float speed;
    public GameObject enemy;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Trigger.canMove == true)
        {
            if (counter != moveSpots.Length)
            {
               // animator.SetBool("walking", true);


                transform.position = moveSpots[counter].position;
                if (Vector2.Distance(transform.position, enemy.transform.position) < 0.2f)
                {

                    
                    counter++;



                }

            }
           /* else
            {
                animator.SetBool("walking", false);


            }
           */

        }
    }
}
