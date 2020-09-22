using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public List<int> thing = new List<int>();

    public bool that = false;
    public void DeleteObject()
    {
        that = true;
    }

    


    void Update()
    {
        if(that == true)
        {
            Destroy(char1);
        }
    }
}
