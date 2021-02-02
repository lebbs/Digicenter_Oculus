using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plamyanimation : MonoBehaviour
{
    [SerializeField] private Animator floorAnimator;
    [SerializeField] private Animator spawnerAnimator;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHand") ||
            other.CompareTag("LeftHand"))

        {
            floorAnimator.SetBool("playOpen", true);
            spawnerAnimator.SetBool("playSpawner", true);

        }

    }

       

}

