using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol2 : MonoBehaviour
{
    public int counter;
    public Transform[] moveSpots;
    public float speed;
    public bool finish;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        finish = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, moveSpots[counter].position) < 0.2f && counter < moveSpots.Length)
        {
            counter++;

        }
       

        if (trigger.canMove == true && counter < moveSpots.Length)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[counter].position, speed * Time.deltaTime);
        }

    }

    

}
