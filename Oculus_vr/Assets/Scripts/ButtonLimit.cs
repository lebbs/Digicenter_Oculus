using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLimit : MonoBehaviour
{

    [SerializeField]

    private GameObject buttonTrigger;

    private Vector3 originalPosition;

    private float minDistance;
    private float maxDistance;


     void Awake()
    {

        minDistance = Vector3.Distance(buttonTrigger.transform.position,
            transform.position);

        maxDistance = buttonTrigger.transform.position.y;

        originalPosition = transform.position;
        
    }

    private void Update()
    {
        if(Vector3.Distance(buttonTrigger.transform.position, transform.position) >= minDistance)
        {
            transform.position = originalPosition;
        }

        if(transform.position.y <= maxDistance)
        {
            transform.position = new Vector3(transform.position.x, maxDistance, transform.position.z);
        }
    }
}
