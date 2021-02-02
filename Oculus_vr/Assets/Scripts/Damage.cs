using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public float damage = 100;

    public AudioSource hit;
    public AudioSource start;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target1") ||
            other.gameObject.CompareTag("DoubleTarget"))
        {
            other.gameObject.SendMessage("OnDamage", damage);
            hit.Play();
        }

        if (other.gameObject.CompareTag("Start"))
        {
            start.Play();
        }
    }
}
