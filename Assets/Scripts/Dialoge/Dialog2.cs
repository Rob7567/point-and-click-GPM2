using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Pathfinding
{

    using Pathfinding.Util;

    public class Dialog2 : MonoBehaviour
    {
        public TextMeshProUGUI textComponent;
        public string[] lines;
        public float textSpeed;

        public AIPath move;
        public AIPath kegel;
        public AIPath player;

        //public GameObject canvas;
        //public GameObject frage;
        //public GameObject player;

        private int index;

        public static bool dialogAusgeführt;

        public static bool gegner = false;

        // Start is called before the first frame update
        void Start()
        {
            textComponent.text = string.Empty;

            StartDialogue();
            //StartDialogue();
            move.canMove = false;
            kegel.canMove = false;
            player.canMove = false;
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

        void StartDialogue()
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
                gameObject.SetActive(false);
                move.canMove = true;
                kegel.canMove = true;
                player.canMove = true;
            }
        }



    }
}
