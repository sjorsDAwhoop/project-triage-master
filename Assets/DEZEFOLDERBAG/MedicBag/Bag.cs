using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Bag : MonoBehaviour
{
    //Op de hand
    public GameObject Hand;
    //Op een kleine cube die in het midden van de tas gaat zitten(die zie je ook niet)
    public GameObject BagSide;
    //De tas zelf
    public GameObject FullBag;

    //deze dingen spreken voor zich
    public GameObject Tourn;
    public GameObject CCeal;
    public GameObject Ars;
    public GameObject Marker;
    public GameObject Bandage;

    private bool Open = false;
    private bool Open2 = false;

    private float RitsHet = 0.1f;

    private bool Tourn1Bool = true;
    private bool CCeal1Bool = true;
    private bool Ars1Bool = true;
    private bool Marker1Bool = true;
    private bool Bandage1Bool = true;

    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        //kijkt hoever de hand van de tas weg is(speciale collider die vast it aan de bovenkant van de tas(die ook verplaatst word als je de tas opent(verder in het script))
        if (Vector3.Distance(Hand.transform.position, BagSide.transform.position) < RitsHet)
        {
            if (Open == true)
            {
                StartCoroutine(MyClosed());
                Debug.Log("111");
            }

            if (Open2 == false)
            {
                StartCoroutine(MyOpen());
                Debug.Log("22222");
            }
        }

        

    }

    //Alles taggen anders werken de bools&triggers ook niet -_-
    //Maak van de collider een trigger (dit is de colider van wat checkt of het in de tas is of niet (die hoort in de tas te zitten))
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tourn")
        {
            Tourn1Bool = true;
        }
        if (other.tag == "CCeal")
        {
            CCeal1Bool = true;
        }
        if (other.tag == "Ars")
        {
            Ars1Bool = true;
        }
        if (other.tag == "Marker")
        {
            Marker1Bool = true;
        }
        if (other.tag == "Bandage")
        {
            Bandage1Bool = true;
        }
    }

     

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tourn")
        {
            Tourn1Bool = false;
        }
        if (other.tag == "CCeal")
        {
            CCeal1Bool = false;
        }
        if (other.tag == "Ars")
        {
            Ars1Bool = false;
        }
        if (other.tag == "Marker")
        {
            Marker1Bool = false;
        }
        if (other.tag == "Bandage")
        {
            Bandage1Bool = false;
        }
    }



    IEnumerator MyOpen()
    {
        Open2 = true;
        m_Animator.Play("Take 001 0", -1, 0f);
        Debug.Log("333333");

        //Start animation of opening bag
        yield return new WaitForSeconds(1.2f);
        if (Tourn1Bool == true)
        {
            Tourn.transform.SetParent(null);
            Tourn.GetComponent<Collider>().enabled = true;
            Tourn.AddComponent<Interactable>();
            Tourn.AddComponent<Throwable>();
        }
        if (CCeal1Bool == true)
        {
            CCeal.transform.SetParent(null);
            CCeal.GetComponent<Collider>().enabled = true;
            CCeal.AddComponent<Interactable>();
            CCeal.AddComponent<Throwable>();
        }
        if (Ars1Bool == true)
        {
            Ars.transform.SetParent(null);
            Ars.GetComponent<Collider>().enabled = true;
            Ars.AddComponent<Interactable>();
            Ars.AddComponent<Throwable>();
        }
        if (Marker1Bool == true)
        {
            Marker.transform.SetParent(null);
            Marker.GetComponent<Collider>().enabled = true;
            Marker.AddComponent<Interactable>();
            Marker.AddComponent<Throwable>();
        }
        if (Bandage1Bool == true)
        {
            Bandage.transform.SetParent(null);
            Bandage.GetComponent<Collider>().enabled = true;
            Bandage.AddComponent<Interactable>();
            Bandage.AddComponent<Throwable>();
        }
        BagSide.transform.position = new Vector3(FullBag.transform.position.x + 0.0027f, FullBag.transform.position.y + 0.126f, FullBag.transform.position.z + -0.0281f);
        yield return new WaitForSeconds(6.0f);
        Open = true;
        Debug.Log("444444");
    }

    IEnumerator MyClosed()
    {
        Open = false;
        //speelt de animatie van het dicht doen van de tas
       
         m_Animator.Play("Take 001", -1, 0f);
        Debug.Log("555555");

        if (Tourn1Bool == true)
        {
            Destroy(Tourn.GetComponent<Throwable>());
            Destroy(Tourn.GetComponent<Interactable>());
            Destroy(Tourn.GetComponent<Rigidbody>());
            Tourn.GetComponent<Collider>().enabled = false;
            Tourn.transform.SetParent(FullBag.transform);
        }
        if (CCeal1Bool == true)
        {
            Destroy(CCeal.GetComponent<Throwable>());
            Destroy(CCeal.GetComponent<Interactable>());
            Destroy(CCeal.GetComponent<Rigidbody>());
            CCeal.GetComponent<Collider>().enabled = false;
            CCeal.transform.SetParent(FullBag.transform);
        }
        if (Ars1Bool == true)
        {
            Destroy(Ars.GetComponent<Throwable>());
            Destroy(Ars.GetComponent<Interactable>());
            Destroy(Ars.GetComponent<Rigidbody>());
            Ars.GetComponent<Collider>().enabled = false;
            Ars.transform.SetParent(FullBag.transform);
        }
        if (Marker1Bool == true)
        {
            Destroy(Marker.GetComponent<Throwable>());
            Destroy(Marker.GetComponent<Interactable>());
            Destroy(Marker.GetComponent<Rigidbody>());
            Marker.GetComponent<Collider>().enabled = false;
            Marker.transform.SetParent(FullBag.transform);
        }
        if (Bandage1Bool == true)
        {
            Destroy(Bandage.GetComponent<Throwable>());
            Destroy(Bandage.GetComponent<Interactable>());
            Destroy(Bandage.GetComponent<Rigidbody>());
            Bandage.GetComponent<Collider>().enabled = false;
            Bandage.transform.SetParent(FullBag.transform);
        }
        //Wacht (eigen input) van hoelang die wacht totdat de spullen in de tas niet meer bruikbaar zijn
        yield return new WaitForSeconds(1.2f);
  //      ParentingFound();
        //veranderd de positie van een object/collider die afgaat waneer je dichtgenoeg erbij bent(zit in het midden van de boven kant van de tas vast)
        BagSide.transform.position = new Vector3(FullBag.transform.position.x + 0.0027f, FullBag.transform.position.y + 0.126f, FullBag.transform.position.z + 0.0281f);
        yield return new WaitForSeconds(6.0f);
        // nu kan de tas weer open gemaakt worden
        Open2 = false;
        Debug.Log("66666");
    }

    //Vergeet niet alle objects te "Taggen"(van de medic spullen) & haal de rigidbody's eraf(van de medic spullen) & zet geen pickup&throwable op de items(van de medic spullen)

   
}


