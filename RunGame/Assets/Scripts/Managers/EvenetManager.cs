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
    private static readonly IDictionary <EventType, UnityAction> dicionary = new Dictionary <EventType, UnityAction> (); 
    
    //구독
    public static void Subscribe(EventType type, UnityAction unityAction) 
    {
        //UnityEvent unityEvent;
        //if (dicionary.TryGetValue(type, out unityAction) == false)
        //{
        //    dicionary.Add (type, unityAction);  
        //}
        //else
        //{

        //}

    }

    //구독 해제
    public static void Unsubscribe(EventType type, UnityAction unityAction)
    {

    }

    //발행 
    public static void Publish(EventType type)
    {

    }




}
