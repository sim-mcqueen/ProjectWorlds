using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    // camera will follow this object
    public Transform target;
    // offset between camera and target
    public Vector3 offset;
    // change this value to get desired smoothness
    public float smoothTime = 0.1f;

    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        transform.position = target.position + offset;
    }

    private void LateUpdate()
    {
        Vector3 finalPosition = target.position + offset;
        Vector3 lerpPosition = Vector3.Lerp(transform.position, finalPosition, smoothTime);
        transform.position = lerpPosition;
    }
}

