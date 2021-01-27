using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSealSnap : MonoBehaviour
{
    private Renderer Rend;
    [SerializeField]
    private DeathCounter deathCounter;
    [SerializeField]
    private float timesafe;
    [SerializeField]
    private ScoreSystem chestSeal;
    [SerializeField]
    private GameObject victim;


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
            chestSeal.AddChestSeal(1);
            deathCounter.AddTime(timesafe);
        }
    }

}
