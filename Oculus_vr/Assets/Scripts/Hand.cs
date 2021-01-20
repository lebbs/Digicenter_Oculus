using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public Climber climber = null;
    public OVRInput.Controller controller = OVRInput.Controller.None;

    private GameObject currentPoint = null;
    public List<GameObject> contactPoints = new List<GameObject>();
    private MeshRenderer meshRenderer = null;

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller))
            GrabPoint();

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, controller))
            ReleasePoint();
    }

    private void GrabPoint()
    {
        currentPoint = Utility.GetNearest(transform.position, contactPoints);

        if (currentPoint)
        {
            meshRenderer.enabled = false;
        }
    }

    private void ReleasePoint()
    {
        if (currentPoint)
        {
            meshRenderer.enabled = true;
        }
        currentPoint = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        AddPoint(other.gameObject);
    }

    private void AddPoint(GameObject newObject)
    {
        if (newObject.CompareTag("ClimbPoint"))
            contactPoints.Add(newObject);
    }


    private void OnTriggerExit(Collider other)
    {
        RemovePoint(other.gameObject);
    }

    private void RemovePoint(GameObject newObject)
    {
        if (newObject.CompareTag("ClimbPoint"))
            contactPoints.Remove(newObject);
    }
}
