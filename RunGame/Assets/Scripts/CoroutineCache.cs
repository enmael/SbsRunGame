using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineCache : MonoBehaviour
{
    class Compaer : IEqualityComparer<float>
    {
        public bool Equals(float x, float y)
        {
            return x == y;  //°°À¸¸é 
        }

        public int GetHashCode(float hash)
        {
           return hash.GetHashCode();
        }
    }

    static readonly Dictionary<float, WaitForSeconds> dictionary = new Dictionary<float, WaitForSeconds>(new Compaer());

    public static WaitForSeconds waitForSecond(float time)
    {
        WaitForSeconds waitForSeconds;

        if (dictionary.TryGetValue(time, out waitForSeconds) ==false)
        {
            dictionary.Add(time, waitForSeconds);
            return waitForSeconds;
        }
        else
        {
             return dictionary[time];   

        }

        
    }
}