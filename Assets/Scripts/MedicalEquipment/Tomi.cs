using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Tomi : MonoBehaviour
{
    // Target = the leg
    //Base = the turning part of the tourniquet
    //MaxRange = Range between the tourniquet and the target
    //MuxRang = Range between Base and Hand position

    public GameObject target;
    public GameObject Base;

    public GameObject ThisTourniquet;

    public GameObject HandR;
    public GameObject HandL;

    public GameObject RoundTourniquet;

    private Vector3 targetTran;

    private int spinCount = 0;
    private float spinY;
    private float maxRange = 0.05f;
    private float MuxRange = 0.07f;

    private bool CanSpin = false;
    private bool SpinStopped = false;


    void Start()
    {
        target = GameObject.FindWithTag("BlownOffPart");
        targetTran = target.transform.position;
        Base = GameObject.FindWithTag("TomTurn");
        
        
    }

    void Update()
    {
      //  spinY = Base.transform.rotation.eulerAngles.y;

        if (Vector3.Distance(transform.position, targetTran) < maxRange && !CanSpin && !SpinStopped)
        {
            Destroy(GetComponent<Throwable>());
            Destroy(GetComponent<Interactable>());
            transform.position = target.transform.position;
            transform.rotation = target.transform.rotation;
            Destroy(GetComponent<Rigidbody>());
            transform.SetParent(target.transform);
            Base.transform.parent = null;

            MeshRenderer m = ThisTourniquet.GetComponent<MeshRenderer>();
            m.enabled = false;

           
            Instantiate(RoundTourniquet);

            RoundTourniquet.transform.position = target.transform.position;
            RoundTourniquet.transform.rotation = target.transform.rotation;

            CanSpin = true;
        }

        if ((CanSpin) && (Vector3.Distance(HandL.transform.position, Base.transform.position) < MuxRange || Vector3.Distance(HandR.transform.position, Base.transform.position) < MuxRange))
        {
            Base.transform.Rotate(Base.transform.rotation.x, Base.transform.rotation.y + 2f, Base.transform.rotation.z);
            if (spinY >= 320f && !SpinStopped)
            {             
                spinY = 0f;
                spinCount++;
                spinY = 0f;
                
                if (spinCount >= 2)
                {
                    SpinStopped = true;
                    CanSpin = false;
                }

            }

        }

    }

}

