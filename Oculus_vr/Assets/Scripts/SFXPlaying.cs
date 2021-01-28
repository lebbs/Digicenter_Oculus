using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource hit;

    public void PlayHit()
    {
        hit.Play();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target1")
            || other.gameObject.CompareTag("DoubleTarget"))
        {
            PlayHit();
        }
    }

}
