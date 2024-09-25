/*
# ----------------------------------------------------------------------------------------
#파일이름 :AudioManager.cs
#생성일 : 2024.09.25
#내용 : 
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
