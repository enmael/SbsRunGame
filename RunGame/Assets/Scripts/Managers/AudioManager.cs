/*
# ----------------------------------------------------------------------------------------
#�����̸� :AudioManager.cs
#������ : 2024.09.25
#���� : 
# ------------------------------------------------------------------------------------------
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager> 
{
    [SerializeField] AudioSource sceneryAudioSoure;
    [SerializeField] AudioSource effectyAudioSoure;
    

    public void Listen(AudioClip audioClip)
    {
        
        effectyAudioSoure.PlayOneShot(audioClip);
       
    }


}
