using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    public List<GameObject> prefabs;

    public GameObject menu;

    public void Spawn(int index)
    {
        Instantiate(prefabs[index], transform.position, transform.rotation);
    }

    public void OpenMenu()
    {
        menu.SetActive(true);
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
    }

    public void CubeScene()
    {
        SceneManager.LoadScene("CubeGame");
    }

    public void BoxingScene()
    {
        SceneManager.LoadScene("Boxing");
    }
   
}
