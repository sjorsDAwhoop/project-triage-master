using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandeler : MonoBehaviour
{
    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
        this.GetComponent<Animator>().speed = Random.Range(0.5f, 1.5f);

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
        anim.SetTrigger("ISWAVING");
    }

    public void breathless()
    {
        anim.Play("Base Layer.breathless", 0, 0);
    }
}
