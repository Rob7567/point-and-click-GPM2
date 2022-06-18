using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachKlein : MonoBehaviour
{
    public void Klein()
    {
        this.gameObject.transform.localScale = new Vector3(0,0,0);
    }

    public void NichtKlein()
    {
        this.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
