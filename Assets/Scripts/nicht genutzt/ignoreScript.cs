using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform gegner;

    void Start()
    {
        Transform bullet = Instantiate(gegner) as Transform;
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
    }
}