
using UnityEngine;
using UnityEngine.AI;

public class newcharactercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    

    public Camera cam;

    public Vector3 mouseposi;
    public Vector3 mousePosWorld;
    public Vector2 mousePosWorld2D;
    public Vector2 targetPos;

    public GameObject player;

    RaycastHit2D hit;

    public float speed;

    public bool isMoving;

    private NavMeshAgent agent;

    private void Start()
    {
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mouseposi = Input.mousePosition;
            
            // Koordinaten zu einem WorldPoint, fals Kamera sich mitbewgen soll
            mousePosWorld = cam.ScreenToWorldPoint(mouseposi);

            mousePosWorld2D = new Vector2(mousePosWorld.x, mousePosWorld.y);
            hit = Physics2D.Raycast(mousePosWorld2D, Vector2.zero);

            //beinhaltet hit einen colider
            if (hit.collider != null)
            {
                Debug.Log("Colider getroffen");

                //Agfrage ob zielort sich auf dem ground befindet
                if(hit.collider.gameObject.tag == "ground")
                    {
                    targetPos = hit.point;
                    }
                isMoving = true;
                CaracterFlip();
                
            }
            else
            {
                Debug.Log("kein colider getroffen");
            }
        }
    }


    private void FixedUpdate()
    {
        if (isMoving)
        {
            agent.transform.position = Vector3.MoveTowards(agent.transform.position, targetPos, speed);
            Debug.Log("l");

            if (agent.transform.position.x == targetPos.x && agent.transform.position.y == targetPos.y)
            {
                isMoving = false;
            }
        }
       
    }


    void CaracterFlip()
    {
        if (agent.transform.position.x > hit.point.x)
        {
            //nach links ausgerichtet
            agent.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            //nach rechts blicken
            agent.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
 