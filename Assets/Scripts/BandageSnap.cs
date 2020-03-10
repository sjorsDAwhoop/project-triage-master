using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandageSnap : MonoBehaviour
{
    private Renderer Rend;

    void Start()
    {
        Rend = GetComponent<Renderer>();
        
    }
   

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("verband"))
        {
            Rend.enabled = true;
            Destroy(col.gameObject);
        } 
    }
    
}
 