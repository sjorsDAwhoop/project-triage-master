using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System;

public class DeathTimer : IDisposable
{
    public bool Finished = false;
    public bool Started = false;
    private readonly Timer _timer;
    public DeathTimer(float time, Action actionToBeExecuted)
    {
        _timer = new Timer
        {
            Interval = time * 1000, // in milliseconds
            AutoReset = false
        };
        _timer.Elapsed += (o, args) =>
        {
            actionToBeExecuted();
            Finished = true;
        };
    }
    public void Start()
    {
        Started = true;
        _timer.Start();
    }
    public void Stop()
    {
        _timer.Stop();
    }
    public void Dispose()
    {
        _timer.Dispose();
    }
}
