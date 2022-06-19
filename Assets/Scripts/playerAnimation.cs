using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Animator animator;
   
    public GameObject player;
     
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        /*if (rigidbody.velocity.magnitude > 0) //Make This a small number
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }*/
        if (bIsOnTheMove == true)
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }
       
        StartCoroutine(CheckMoving());
    }
    
     public bool bIsOnTheMove = false;
    private IEnumerator CheckMoving()
    {
        Vector3 startPos = player.transform.position;
        yield return new WaitForSeconds(0.1f);
        Vector3 finalPos = player.transform.position;
        if (startPos.x != finalPos.x || startPos.y != finalPos.y
            || startPos.z != finalPos.z)
        {
            bIsOnTheMove = true;
        }
           else
        {
            bIsOnTheMove = false;
        }
    }

}
