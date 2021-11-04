using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSlimeMovment : MonoBehaviour
{
    public float MoveSpeed;
    public int Boundry;

    private Vector2 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        MoveSpeed /= 100;
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(MoveSpeed, 0, 0);
        if ((initialPos.x + Boundry) < transform.position.x)
        {
            MoveSpeed = -MoveSpeed;
            transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
        }
        if ((initialPos.x - Boundry) > transform.position.x)
        {
            MoveSpeed = -MoveSpeed;
            transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
        }
    }
}
