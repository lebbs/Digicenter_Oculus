using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Goal : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject player;

    public Vector3 distance = new Vector3(0f, 0.99f, 0);

    private CharacterController characterController;

    private void Start()
    {
        characterController = player.GetComponent<CharacterController>();

    }

    public void Spawn()
    {
        player.transform.position = spawnPoint.transform.localPosition + distance;

    }

    

    private void OnTriggerEnter(Collider other)
    {

        characterController.enabled = false;
        Spawn();
       // gameObject.SetActive(false);

    }

    private void OnTriggerExit(Collider other)
    {
        characterController.enabled = true;
       // gameObject.SetActive(true);
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            characterController.enabled = !characterController.enabled;
            player.transform.position = spawnPoint.transform.localPosition + distance;

            
        }
    }

}
