using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandPosition : MonoBehaviour
{

    public Transform target;
    public TextMesh text;

    private void Update()
    {
        text.text = target.position.ToString("F2");

        float handHeight = target.transform.position.y;

        if(handHeight > 1)
        {
            Debug.Log(handHeight);
        }


    }

}
