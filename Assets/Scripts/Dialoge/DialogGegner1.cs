using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Pathfinding
{

    using Pathfinding.Util;

    public class DialogGegner1 : MonoBehaviour
    {
        public TextMeshProUGUI textComponent;
        public string[] lines;
        public float textSpeed;

        public AIPath move;

        public GameObject canvas;
        public GameObject player;

        private int index;

        public static bool dialogAusgeführt;

        public static int fertig = 0;

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
                canvas.SetActive(false);
                move.canMove = true;
                fertig += 1;
            }
        }

        private void OnMouseDown()
        {
            if (Vector2.Distance(transform.position, player.transform.position) < 2.8f)
            {
                textComponent.text = string.Empty;
                canvas.SetActive(true);
                StartDialogue();
                move.canMove = false;
            }


        }

    }
}

