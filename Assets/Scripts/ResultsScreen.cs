using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class results : MonoBehaviour
{
    public Text writetext;
    public void TRedMarkText(RaycastHit hit)
    {
        writetext.text = hit.transform.root + "has been marked by T1mark ";
    }
}
