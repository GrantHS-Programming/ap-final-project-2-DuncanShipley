using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private vooid Update()
    {
        transform.position = cameraPosition.position;
    }
}
