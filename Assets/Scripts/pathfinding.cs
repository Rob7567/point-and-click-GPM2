using UnityEngine;
using UnityEngine.AI;

public class pathfinding : MonoBehaviour
{


    public Camera cam;

    public NavMeshAgent agent;

   
    // Start is called before the first frame update
    void Start()
    {
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Character Bewegen
                agent.SetDestination(hit.point);
            }
        }
    }
}
