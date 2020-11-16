using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandeler : MonoBehaviour
{
    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void dead()
    {
        anim.SetBool("isdead", true);
    }
    public void dying()
    {
        anim.SetBool("isdying", true);
    }
    public void waving()
    {
        anim.SetBool("iswaving", true);
    }

    public void breathless()
    {
        anim.Play("Base Layer.breathless", 0, 0);
    }
}
