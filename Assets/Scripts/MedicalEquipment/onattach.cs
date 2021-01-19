using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onattach : MonoBehaviour
{

    [SerializeField]
    private AnimationHandeler handeler;
    
    public void grabshoulder()
    {
        handeler.roll();
    }

}
