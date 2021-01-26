using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByPosition : MonoBehaviour
{
    public float destroyPositionY = -10;
    public float destroyPositionZ = -10;
    void Update()
    {
        if(transform.position.y < destroyPositionY ||
            transform.position.z < destroyPositionZ) 
        {
            Destroy(this.gameObject); //Destroy gameobject if fallen 10 meters below ground level
        }   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
    }
   
}
