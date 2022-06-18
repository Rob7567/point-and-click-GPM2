using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetPosE1 : MonoBehaviour
{
    public int counter;
    public Transform[] moveSpots;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, enemy.transform.position) < 0.2f)
        {
            counter++;

        }
        if (counter == moveSpots.Length)
        {
            counter = 0;
        }
        transform.position = moveSpots[counter].position;

    }
}
