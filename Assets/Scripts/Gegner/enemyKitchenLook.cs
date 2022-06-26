using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKitchenLook : MonoBehaviour
{
    public int counter = 0;
    public bool quit = false;
    public Transform[] moveSpots;
    public SpriteRenderer enemy;

    public bool l�uft;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == moveSpots.Length)
        {
            counter = 0;
        }
        transform.position = moveSpots[counter].position;
        if (counter % 2 == 1)
        {
            enemy.flipX = false;
        }
        else enemy.flipX = true;

        if(Pathfinding.Dialog3.dialogZeug == true)
        {
            StopAllCoroutines();
            l�uft = false;
        }
        else if(l�uft == false)
        {
            StartCoroutine(waiter());
        }

    }

    public IEnumerator waiter()
    {
        l�uft = true;
        while (quit == false)
        {
            yield return new WaitForSeconds(5);
            counter++;
            

        }
        
        
        
    }
}
