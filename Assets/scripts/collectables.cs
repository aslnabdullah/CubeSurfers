using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
{
    bool isGathered;
    int index;
    public picker picker;
    void Start()
    {
        isGathered = false;
    }

    void Update()
    {
        if (isGathered == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);

            }

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            picker.HeightDecrease();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
    }

    public bool İsGetGathered()
    {
        return isGathered;

    }
    public void YesMake()
    {
        isGathered = true;
    }
    public void Makeİndex(int index)
    {
        this.index = index;

    }
}
