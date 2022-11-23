using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraExamen : MonoBehaviour
{
    [SerializeField]private Transform cameraTarget;
    [SerializeField]private Vector3 offset;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPos = new Vector3(cameraTarget.position.x + offset.x, cameraTarget.position.y + offset.y, offset.z);
        transform.position = new Vector3(desiredPos.x, desiredPos.y, desiredPos.z);
    }
}
