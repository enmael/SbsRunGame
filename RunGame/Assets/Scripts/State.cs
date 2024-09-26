using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] protected bool stat;

    protected void OnEnable()
    {
        EvenetManager.Subscribe(EventType.START, OnExecute);
        EvenetManager.Subscribe(EventType.STOP, OnStop);
    }
    protected void OnExecute()
    {
        stat = true;
    }

    protected void OnStop()
    {
        stat = false;
    }

    protected void OnDisable()
    {
        EvenetManager.Unsubscribe(EventType.START, OnExecute);
        EvenetManager.Unsubscribe(EventType.STOP, OnStop);

    }


}
