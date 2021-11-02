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
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, transform.position.y));
        Vector2 forward = mouseWorld - transform.position;
        if (forward.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (forward.x > 0)
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
