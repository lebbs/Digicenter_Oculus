using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource audioSource;

    public void PlayAudio()
    {
        audioSource.Play();
    }

}
