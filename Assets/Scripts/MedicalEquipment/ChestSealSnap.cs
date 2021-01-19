using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSealSnap : MonoBehaviour
{
    private Renderer Rend;
    [SerializeField]
    private DeathCounter deathCounter;
    [SerializeField]
    private ScoreSystem score;
    [SerializeField]
    private float timesafe;

    
    void Start()
    {
        Rend = GetComponent<Renderer>();

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("CCeal"))
        {
            Rend.enabled = true;
            Destroy(col.gameObject);
            deathCounter.AddTime(timesafe);
            score.AddScore(15);
        }
    }

}
