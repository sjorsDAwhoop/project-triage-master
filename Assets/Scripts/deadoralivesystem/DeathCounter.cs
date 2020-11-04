using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    [SerializeField]
    private float timer;
    [SerializeField]
    private AnimationHandeler handeler;

    public void AddTime(float addtime)
    {
        timer += addtime;
    }


    private void Update()
    {
        timer -= Time.deltaTime;

        
        if (timer <= 0)
        {
            handeler.dead();
        }

        if(timer <= 20 && timer >= 0)
        {
            handeler.dying();
            
        }
    }


}
