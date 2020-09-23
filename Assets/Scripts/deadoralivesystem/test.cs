using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    private DeathCounter deathCounter;

    public void OnClick()
    {
        deathCounter.AddTime(5f);
    }
}
