using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject MainCube;
    public Vector3 distance;
    void Start()
    {
        distance = transform.position - MainCube.transform.position;
        
    }

    private void LateUpdate()
    {
        //this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + disatance, 0.25f);
        transform.position = MainCube.transform.position + distance;
        
    }
}
