using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryCam : MonoBehaviour
{
    public float leftBoundry;
    public float rightBoundry;
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;

    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if(Target.position.x > leftBoundry && Target.position.x < rightBoundry)
        {
            Vector3 targetPosition = Target.position + Offset;
            camTransform.position = Vector3.SmoothDamp(transform.position, new Vector3(targetPosition.x, transform.position.y, transform.position.z), ref velocity, 0);
        }
    }
}
