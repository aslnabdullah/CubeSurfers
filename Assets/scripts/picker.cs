using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picker : MonoBehaviour
{
    GameObject MainCube;
    int height;
    void Start()
    {
        MainCube = GameObject.Find("MainCube");
        
    }

    void Update()
    {
        MainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
        
    }
    public void HeightDecrease()
    {
        height--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectable" && other.gameObject.GetComponent<collectables>().İsGetGathered()==false)
        {
            height += 1;
            other.gameObject.GetComponent<collectables>().YesMake();
            other.gameObject.GetComponent<collectables>().Makeİndex(height);
            other.gameObject.transform.parent = MainCube.transform;



        }
    }
}
