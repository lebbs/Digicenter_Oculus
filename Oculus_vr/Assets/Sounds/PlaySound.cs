using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource audioSource1;

    public AudioSource audioSource2;


    public void PlayAudio()
    {
        audioSource1.Play();
    }

    public void PlayAudioClose()
    {
        audioSource2.Play();
    }

}
