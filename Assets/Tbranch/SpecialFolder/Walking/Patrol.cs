using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour
{

    public GameObject[] points;
    private int destPoint = 0;

    public GameObject T3Walking;

    private GameObject target;

    public float Speed;

    public Rigidbody rb;

    private int i;

    private float BeingClose = 0.5f;

    public float lookspeed;

    void Start()
    {
        i = 0;
        rb = GetComponent<Rigidbody>();
    }




    void Update()
    {
        target = points[i];
        //transform.LookAt(target.transform);
       var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, lookspeed * Time.deltaTime);
        rb.velocity = transform.forward * Speed;
       

        if (Vector3.Distance(T3Walking.transform.position, points[i].transform.position) <= BeingClose)
        {
            i++;
        }

       // if (T3Walking.transform.position == points[i].transform.position)
      //  {
      //      i++;
     //       
      //  }
        if(i == 6)
        {
            i = 0;
        }
    }
}
