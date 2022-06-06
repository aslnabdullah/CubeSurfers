using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 moveDirection;
    public float velocity;

    void Start()
    {
        
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(moveDirection.x * velocity * Time.deltaTime, 0, moveDirection.z * velocity * Time.deltaTime);
        
    }
}
