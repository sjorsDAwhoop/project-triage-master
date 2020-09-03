using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victim
{
    
    public int timeleft;
    public GameObject body;

    public Victim( int newTimeLeft, GameObject newbody)
    {
        
        timeleft = newTimeLeft;
        body = newbody;
        
    }


}
