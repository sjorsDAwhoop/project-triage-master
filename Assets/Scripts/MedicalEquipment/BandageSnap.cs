﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandageSnap : MonoBehaviour
{
    private Renderer Rend;
    private Collider Collide;
    [SerializeField]
    private DeathCounter deathCounter;
    [SerializeField]
    private ScoreSystem score;
    [SerializeField]
    private float timesafe;

    void Start()
    {
        Rend = GetComponent<Renderer>();
        Collide = GetComponent<Collider>();
        
    }
   

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("verband"))
        {
            Rend.enabled = true;
            Destroy(col.gameObject);
            deathCounter.AddTime(timesafe);
            score.AddScore(15);
            Collide.isTrigger = false;
        } 
    }
    
}
 