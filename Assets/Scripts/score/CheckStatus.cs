using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatus : MonoBehaviour
{
    void Start()
    {

        DisplayChildren(transform);
    }

    void DisplayChildren(Transform trans)
    {
        foreach (Transform child in trans)
        {
            
            if (child.childCount > 0)
            {
                DisplayChildren(child);
            }
            if(child.CompareTag("Bandage"))
            {
                Debug.Log(gameObject.name + "needs bandage");
            }
            if (child.CompareTag("CCeal"))
            {
                Debug.Log(gameObject.name + "needs chestseal");
            }
        }
    }
}