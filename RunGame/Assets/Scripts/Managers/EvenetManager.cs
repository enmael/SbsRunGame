using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public enum EventType
    {
        START,
        CONTINUE,
        PAUSE,
        STOP
    }
public class EvenetManager
{

    private static readonly IDictionary<EventType, UnityEvent> dictionary = new Dictionary<EventType, UnityEvent>();

    // 备刀
    public static void Subscribe(EventType eventType, UnityAction unityAction)
    {
        UnityEvent unityEvent = null;

        if (dictionary.TryGetValue(eventType, out unityEvent))
        {
            unityEvent.AddListener(unityAction);
        }
        else
        {
            unityEvent = new UnityEvent();

            unityEvent.AddListener(unityAction);

            dictionary.Add(eventType, unityEvent);
        }
    }

    // 备刀 秦力
    public static void Unsubscribe(EventType eventType, UnityAction unityAction)
    {
        UnityEvent unityEvent = null;

        if (dictionary.TryGetValue(eventType, out unityEvent))
        {
            unityEvent.RemoveListener(unityAction);
        }
    }

    //惯青 
    public static void Publish(EventType eventType)
    {
        UnityEvent unityEvent = null;

        if (dictionary.TryGetValue(eventType, out  unityEvent))
        { 
            unityEvent.Invoke();
        }
        
    }
}
