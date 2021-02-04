using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpawns : MonoBehaviour
{

    public GameObject spawnerRight;
    public GameObject spawnerLeft;
    public GameObject spawnerMiddle;


    void ActivateSpawn()
    {
        spawnerRight.SetActive(true);
        spawnerLeft.SetActive(true);
        spawnerMiddle.SetActive(true);
    }

    void DeactivateSpawn()
    {
        spawnerRight.SetActive(false);
        spawnerLeft.SetActive(false);
        spawnerMiddle.SetActive(false);
    }
    
}
