using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("RightHand")||
            other.gameObject.CompareTag("LeftHand"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

   

}
