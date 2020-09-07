using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class bodycounter : MonoBehaviour
{
    public List<float> _timeleft = new List<float>();
    public List<DeathTimer> _timers = new List<DeathTimer>();

    public void Start()
    {
        _timeleft.Add(5f);
        _timeleft.Add(1f);
        _timers.Add(new DeathTimer(_timeleft[0], () => Debug.Log("Timer one finished.")));
        _timers.Add(new DeathTimer(_timeleft[1], () => Debug.Log("Timer two finished.")));
        _timers.Add(new DeathTimer(10f, () => Debug.Log("Timer three finished")));

    }

    public void Update()
    {
        if (_timers.Count > 0)
        {
            foreach (var timer in _timers.Where(a => !a.Started))
            {
                timer.Start();
            }

            foreach (var timer in _timers.Where(a => a.Finished))
            {
                timer.Dispose();
            }
            _timers.RemoveAll(a => a.Finished);
        }
    }

}