using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding
{
    using Pathfinding.Util;

    public class Hide : MonoBehaviour
    {
        public bool isHiding = false;

        public Transform box;

        public float dist;
        //public SpriteRenderer spriteRenderer;
        public Rigidbody2D rigidbody2D;

        public AIPath move;

        // Hab hier was hinzugefügt LG Rob
        public bool gameOver = false;
        public bool found = false;

        /*
        private void OnTriggerStay2D(Collider2D other)
        {
            Debug.Log("berührt");
            if (other.gameObject.layer == LayerMask.NameToLayer("Box"))
            {
                Debug.Log("funzt1");
                if (isHiding == false)
                {
                    Debug.Log("funzt2");
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("es funktioniert!!!!11elf");
                        isHiding = true;
                        //gameObject.SetActive(false);
                    }
                }

            }
        }
        */

        private void Update()
        {
            CheckDistance();

            if (isHiding == false)
            {
                HideinBox();
            }
            else
            {
                UnHide();
            }
           
            // Hab hier was hinzugefügt LG Rob
            if (isHiding == false && found == true)
            {
               
                    gameOver = true;
                
            }

        }

        public void HideinBox()
        {
            if (dist <= 1.8f && dist > 0)
            {
                if (isHiding == false)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //Debug.Log("es funktioniert!!!!11elf");

                        rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;

                        move.canMove = false;

                        gameObject.transform.localScale = new Vector3(0, 0, 0);
                        //Disable detection somehow

                        isHiding = true;
                    }
                }
            }
        }

        public void UnHide()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                rigidbody2D.constraints = RigidbodyConstraints2D.None;

                move.canMove = true;

                gameObject.transform.localScale = new Vector3(1, 1, 1);
                //Enable detection somehow

                isHiding = false;
            }

        }

        public void CheckDistance()
        {
            if (box)
            {
                dist = Vector3.Distance(box.position, transform.position);
                //print("Distance to other: " + dist);


            }

        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Box"))
            {
                box = other.gameObject.transform;
            }
            // Hab hier was hinzugefügt LG Rob
            if (other.gameObject.layer == LayerMask.NameToLayer("sichtkegel"))
            {

                found = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Box"))
            {
                box = null;
            }
        }

        
        
    }

}