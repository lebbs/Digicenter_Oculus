using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.Linq;

public class HandPosition : MonoBehaviour
{

    public Transform target;
    public TextMesh text;


    private float startHandHeight;

    public float handHeight;


    private void Start()
    {
        startHandHeight = target.transform.position.y;
    }


    private void Update()
    {
        float handHeight = target.transform.position.y;


        if (handHeight > startHandHeight) 
        {
            text.text = target.position.ToString("F2");
            Start();

        }

        //foreach (var item in array)
        //{
        //    if (item.transform.position.y > handHeight)
        //    {
        //        SaveList.Add(item.transform);
        //    }

        //    //if (SaveList.Count > 10)
        //    //{
        //    //    Debug.Log("jee");
        //    //}


        //}


        


    }

}
