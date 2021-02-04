using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plamyanimation : MonoBehaviour
{
    [SerializeField] private Animator floorAnimator;
    [SerializeField] private Animator spawnerAnimator;

    public  GameObject spawner;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("RightHand") ||
    //        other.CompareTag("LeftHand"))

    //    {
    //        floorAnimator.SetBool("playOpen", true);
    //        spawnerAnimator.SetBool("playSpawner", true);

    //    }

    //}

    public void ActivateGame()
    {
        floorAnimator.SetBool("playOpen", true);
        spawnerAnimator.SetBool("playSpawner", true);
    }

    public void CloseGame()
    {
        //floorAnimator.SetBool("playOpen", false);
        spawnerAnimator.SetBool("closeSpawner", true);

        spawner.GetComponent<Animator>().Play("SpawnerAnimationClose");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            spawner.GetComponent<Animator>().Play("SpawnerAnimationClose");

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            spawner.GetComponent<Animator>().Play("SpawnerAnimation");

        }
    }


}

