using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandageSnap : MonoBehaviour
{
    private Renderer Rend;
    private Collider Collide;
    [SerializeField]
    private DeathCounter deathCounter;
    [SerializeField]
    private float timesafe;
    [SerializeField]
    private ScoreSystem bandage;

    void Start()
    {
        Rend = GetComponent<Renderer>();
        Collide = GetComponent<Collider>();
        
    }
   

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Bandage"))
        {
            Rend.enabled = true;
            Destroy(col.gameObject);
            bandage.Addbandage(1);
            GetComponent<Collider>().enabled = false;
            deathCounter.AddTime(timesafe);
        } 
    }
    
}
 