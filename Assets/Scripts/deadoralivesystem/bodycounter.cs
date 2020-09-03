using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodycounter : MonoBehaviour
{
    public float human1TimeLeft = 10;
    public bool timerIsRunning = false;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (human1TimeLeft > 0)
            {
                human1TimeLeft -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                human1TimeLeft = 0;
                timerIsRunning = false;
            }
        }
    }

}