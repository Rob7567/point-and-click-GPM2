using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Pathfinding
{

    using Pathfinding.Util;
    public class Dialog3 : MonoBehaviour
    {
        public TextMeshProUGUI textComponent;
        public string[] lines;
        public float textSpeed;

        public AIPath move;
        public AIPath kegel;

        //public enemyKitchenLook enemy;

        public GameObject canvas;
        
        public GameObject player;
        //public GameObject point;

        private int index;

        public static bool dialogAusgeführt;
        public static bool dialogZeug;

        // Start is called before the first frame update
        void Start()
        {

            //StartDialogue();
        }
        
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }

        public void StartDialogue()
        {
            
            index = 0;
            StartCoroutine(TypeLine());
        }

        IEnumerator TypeLine()
        {
            //Type each character 1 by 1
            foreach (char c in lines[index].ToCharArray())
            {
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
        }

        void NextLine()
        {
            if (index < lines.Length - 1)
            {
                index++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
            else
            {
                canvas.SetActive(false);
                move.canMove = true;
                kegel.canMove = true;
                //point.SetActive(true);
                //enemy.StartCoroutine(enemy.waiter());
                dialogZeug = false;
            }
        }

        public void DialogStart()
        {
            textComponent.text = string.Empty;
            move.canMove = false;
            kegel.canMove = false;
            canvas.SetActive(true);
            //enemy.StopAllCoroutines();
            //point.SetActive(false);
            dialogZeug = true;
        }

        

    }
}

