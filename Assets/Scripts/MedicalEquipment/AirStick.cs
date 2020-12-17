using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class AirStick : MonoBehaviour
{
    public GameObject Stick;
    public GameObject Pull;
    public GameObject ChestTarget;

    private bool Inserted = false;
    private bool StickDone = false;


    void Start()
    {
        ChestTarget = GameObject.FindWithTag("ChestPart");
        Pull = GameObject.FindWithTag("PullPoint");
        Stick = GameObject.FindWithTag("StickPoint");
    }


    void Update()
    {

        if (Inserted && !StickDone)
        {
            Stick.transform.SetParent(ChestTarget.transform);
            Pull.transform.SetParent(ChestTarget.transform);
            Pull.transform.parent = null;
            StickDone = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ChestTarget)
        {
            Inserted = true;
        }
        
    }  

}
