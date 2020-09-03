using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class bodycounter : MonoBehaviour
{
    private readonly List<UnityTimer> _timers = new List<UnityTimer>();

    public void Start()
    {
        _timers.Add(new UnityTimer(5f, () => Debug.Log("Timer one finished.")));
        _timers.Add(new UnityTimer(1f, () => Debug.Log("Timer two finished.")));
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