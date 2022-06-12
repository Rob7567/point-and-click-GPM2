using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol3 : MonoBehaviour
{

    public int counter;
    public Transform[] moveSpots;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.canMove == true )
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[2].position, speed * Time.deltaTime);
        }
    }
}
