using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSealSnap : MonoBehaviour
{
    private Renderer Rend;

    void Start()
    {
        Rend = GetComponent<Renderer>();

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("chestseal"))
        {
            Rend.enabled = true;
            Destroy(col.gameObject);
        }
    }

}
