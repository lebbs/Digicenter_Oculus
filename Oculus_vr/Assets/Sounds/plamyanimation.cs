using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plamyanimation : MonoBehaviour
{
    [SerializeField] private Animator floorAnimator;
    [SerializeField] private Animator spawnerAnimator;

    public  GameObject spawner;
    public GameObject floor;

    public void ActivateGame()
    {
        spawner.GetComponent<Animator>().Play("SpawnerAnimation");
        floor.GetComponent<Animator>().Play("OpenFloor");
        
    }

    public void CloseGame()
    {
       

        spawner.GetComponent<Animator>().Play("SpawnerAnimationClose");
        floor.GetComponent<Animator>().Play("OpenFloor");


    }

   

}

