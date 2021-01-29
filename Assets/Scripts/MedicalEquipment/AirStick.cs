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

    public GameObject Capsuletop;
    public GameObject Capsulebottem;

    private float maxRange = 0.8f;

    private bool oi = false;

    private bool eiei = false;

    private bool Yeet = true;



    void Start()
    {
        
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, ChestTarget.transform.position) < maxRange && oi == false)
        {
            oi = true;
            Capsuletop.transform.parent = null;
            Capsuletop.AddComponent<Rigidbody>();
            Capsuletop.AddComponent<BoxCollider>();
            Capsulebottem.transform.parent = null;
            Capsulebottem.AddComponent<Rigidbody>();
            Capsulebottem.AddComponent<BoxCollider>();

        }

        

        if (Inserted && !StickDone)
        {

            if (Yeet == true)
            {
                Yeet = false;
                transform.position = ChestTarget.transform.position;
                transform.rotation = ChestTarget.transform.rotation;
                Stick.transform.SetParent(ChestTarget.transform);
                Pull.transform.SetParent(ChestTarget.transform);
                Pull.transform.parent = null;
                //Set Haalweg + collider transform interactable throwable
                //set ars  - collider transform interactable throwable

                Destroy(Stick.GetComponent<Throwable>());
                Destroy(Stick.GetComponent<Interactable>());
                Destroy(Stick.GetComponent<Rigidbody>());
                Destroy(Stick.GetComponent<BoxCollider>());


                Pull.AddComponent<Interactable>();

             
                eiei = true;
            }


            if (eiei == true && Pull.transform.position.y >= ChestTarget.transform.position.y + 0.15f)
            {
                Pull.AddComponent<BoxCollider>();
                Pull.AddComponent<Rigidbody>();
                Pull.AddComponent<Throwable>();
                StickDone = true;
            }
        }

        
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChestPart")
        {
            Inserted = true;
            Debug.Log("1111111111111111");
        }
        
    }  

}
