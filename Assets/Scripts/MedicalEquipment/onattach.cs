using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onattach : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Function("hi there");
    }

    // Update is called once per frame
    public void Function(string sayit)
    {
        Debug.Log(sayit);
    }

}
