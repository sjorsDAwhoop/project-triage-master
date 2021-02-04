using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallShinook : MonoBehaviour
{

    public GameObject RedLight;
    public GameObject ShinookBody;
    public GameObject Shinook;
    public GameObject Hand;
    public GameObject Radio;


    public GameObject Shinookspawn;

    private float CloseTo = 0.2f;

    public GameObject[] points;
    private int i = 0;
    private GameObject target;
    public float Speed;
    public Rigidbody Shinookrb;
    private float BeingClose = 3.5f ;
    public float lookspeed;
    public Rigidbody rb;

    private bool EndingBegins = false;
    private bool yes = false;
    private bool LichtKnipper = true;



    public bool HETEINDEBEGINT = false;



    void Start()
    {
        Shinook = GameObject.FindGameObjectWithTag("Shinook");
    }

    
    void Update()
    {
        if (HETEINDEBEGINT == true)
        {
            
            if (Vector3.Distance(Hand.transform.position, Radio.transform.position) <= CloseTo && yes == false)
            {
                Shinook.GetComponent<AudioSource>().enabled = true;
               // Shinook.GetComponent<MeshRenderer>().enabled = true;
                // Instantiate(ShinookBody, Shinookspawn.transform.position, Shinook.transform.rotation);
                rb = Shinook.GetComponent<Rigidbody>();
                yes = true;
                Shinook = GameObject.FindGameObjectWithTag("Shinook");
                
            }

            Shinookrb = Shinook.GetComponent<Rigidbody>();
            rb = Shinook.GetComponent<Rigidbody>();
            if (yes == true)
            {
                LichtKnipper = false;
                target = points[i];

                var targetRotation = Quaternion.LookRotation(target.transform.position - Shinook.transform.position);
                Shinook.transform.rotation = Quaternion.Slerp(Shinook.transform.rotation, targetRotation, lookspeed * Time.deltaTime);
                rb.velocity = Shinook.transform.forward * Speed;


                if (Vector3.Distance(Shinook.transform.position, points[i].transform.position) <= BeingClose)
                {
                    i++;
                }

                if (i == 4)
                {

                    rb.velocity = Shinook.transform.forward * 0;
                    EndingBegins = true;
                }
            }

            if (LichtKnipper == true)
            {
                LichtKnipper = false;
                StartCoroutine(MyOpen());
            }
        }
    }

    IEnumerator MyOpen()
    {
        RedLight.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        RedLight.SetActive(false);
        yield return new WaitForSeconds(1.2f);
        LichtKnipper = true;
    }
}
