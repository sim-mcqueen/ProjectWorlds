using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointArc : MonoBehaviour
{
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;

    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;

    public int InitialOffset;

    private void Start()
    {
        Offset = camTransform.position - Target.position;
    }

    


    private void LateUpdate()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, transform.position.y));
        Vector2 forward = mouseWorld - transform.position;
        float arcTan = Mathf.Atan(forward.y / forward.x);
        Offset.x = Mathf.Cos(arcTan) + InitialOffset;
        Offset.y = Mathf.Sin(arcTan) + InitialOffset;
        if(forward.x < 0 || (forward.x < 0 && forward.y < 0))
        {
            Debug.Log("one negative");
            Offset.x = -1 * Offset.x;
            Offset.y = -1 * Offset.y;
        }
        else
        {
            Debug.Log("zero negative");
        }
        // update position
        Vector3 targetPosition = Target.position + Offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0);
        // player fire
    }
}
