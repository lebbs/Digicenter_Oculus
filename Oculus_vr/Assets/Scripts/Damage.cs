using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public float damage = 100;

    public AudioSource hit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target1") ||
            other.gameObject.CompareTag("DoubleTarget"))
        {
            other.gameObject.SendMessage("OnDamage", damage);
            hit.Play();
        }
    }
}
