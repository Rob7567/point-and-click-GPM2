using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GegnerAnim : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Animator animator;
    public AudioSource enemyAudio;

    public GameObject enemy;

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
        if (OnTheMove == true)
        {
            animator.SetBool("walk", true);

        }
        else
        {
            animator.SetBool("walk", false);

        }

        if (OnTheMove == true && !enemyAudio.isPlaying)
        {
            enemyAudio.Play();
        }
        else if (OnTheMove == false)
        {
            enemyAudio.Pause();
        }


        StartCoroutine(CheckMoving());
    }

    public bool OnTheMove = false;
    private IEnumerator CheckMoving()
    {
        Vector3 startPos = enemy.transform.position;
        yield return new WaitForSeconds(0.1f);
        Vector3 finalPos = enemy.transform.position;
        if (startPos.x != finalPos.x || startPos.y != finalPos.y
            || startPos.z != finalPos.z)
        {
            OnTheMove = true;
        }
        else
        {
            OnTheMove = false;
        }
    }
}
