using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ChestC : MonoBehaviour
{
    public GameObject Ceal;
    public GameObject BHole;

    private bool Inserted = false;
    private bool StickDone = false;


    void Start()
    {
        BHole = GameObject.FindWithTag("BulletHole");
        Ceal = GameObject.FindWithTag("CCeal");
    }


    void Update()
    {

        if (Inserted && !StickDone)
        {
            Destroy(GetComponent<Throwable>());
            Destroy(GetComponent<Interactable>());
            Ceal.transform.SetParent(BHole.transform);
            Ceal.transform.position = BHole.transform.position;
            Ceal.transform.rotation = BHole.transform.rotation;
            StickDone = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == BHole)
        {
            Inserted = true;
        }

    }
}
