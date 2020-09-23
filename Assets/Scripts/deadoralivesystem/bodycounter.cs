using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BodyCounter : MonoBehaviour
{

    public List<float> _timeleft = new List<float>();
    public List<DeathTimer> _timers = new List<DeathTimer>();
    private Test test;

    
   
    public void Start()
    {
        
        _timeleft.Add(5f);
        _timeleft.Add(1f);
        _timeleft.Add(10f);
        test = gameObject.GetComponent<Test>();


<<<<<<< HEAD
        //_timers.Add(new DeathTimer(_timeleft[0], () =>  ));
=======
        _timers.Add(new DeathTimer(_timeleft[0], () => test.DeleteObject()));
>>>>>>> parent of b1d04f2... Revert "22-09 commit"
        _timers.Add(new DeathTimer(_timeleft[1], () => Debug.Log("Timer two finished.")));
        _timers.Add(new DeathTimer(_timeleft[2], () => Debug.Log("Timer three finished")));


        
       
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