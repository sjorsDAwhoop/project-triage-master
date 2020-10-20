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
        anim.Play("Base Layer.dying", 0, 0);
    }       

    public void breathless()
    {
        anim.Play("Base Layer.breathless", 0, 0);
    }
}
