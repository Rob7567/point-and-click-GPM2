using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolLog : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpots;
    private int Spot;


    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        Spot = Random. Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[Spot].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[Spot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                Spot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
