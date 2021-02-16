using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCubeGame : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject start;
    public GameObject handPosition;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RightHand")||
            other.gameObject.CompareTag("LeftHand"))
        {
            handPosition.GetComponent<HandPosition>().enabled = true;
            gameObject.SetActive(true);            
            start.SetActive(false);
        }
    }
}
