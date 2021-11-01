/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/1/21
//// Proj: ProjectWorlds
//// Desc: Allows the player to move and jump
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 1f;
    public float JumpForce = 1f;


    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        if(movement < -0.001f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement > 0.001f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(RB.velocity.y) < 0.001f)
        {
            RB.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
