using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public float delay = 3f;

    public GameObject gameObject;
    // Start is called before the first frame update
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        Toggle();
    }

    public void Toggle()
    {
        gameObject.SetActive(true);
    }
}
