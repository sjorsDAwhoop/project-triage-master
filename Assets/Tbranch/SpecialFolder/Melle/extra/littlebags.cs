using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class littlebags : MonoBehaviour
{

    public GameObject LBag;

    public GameObject Hand;

    public GameObject Tourn;
    public GameObject CCeal;
    public GameObject Bandage;

    private float RitsHet = 0.3f;

    Animator m_Animator;

    private bool okay = true;

    void Start()
    {

        LBag = this.gameObject;
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if (Vector3.Distance(Hand.transform.position, LBag.transform.position) <= RitsHet && okay == true)
        {

            StartCoroutine(LBopen());


        }
    }


    IEnumerator LBopen()
    {
        okay = false;
        m_Animator.Play("Take 001", -1, 0f);
        yield return new WaitForSeconds(1.2f);
        
            Tourn.transform.SetParent(null);
            Tourn.GetComponent<Collider>().enabled = true;
            Tourn.AddComponent<Interactable>();
            Tourn.AddComponent<Throwable>();
        
    
            CCeal.transform.SetParent(null);
            CCeal.GetComponent<Collider>().enabled = true;
            CCeal.AddComponent<Interactable>();
            CCeal.AddComponent<Throwable>();

        Bandage.transform.SetParent(null);
        Bandage.GetComponent<Collider>().enabled = true;
        Bandage.AddComponent<Interactable>();
        Bandage.AddComponent<Throwable>();

        

    }

}
