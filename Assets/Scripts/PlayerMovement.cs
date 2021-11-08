/////////////////////////////////////////////////
//// Name: Sim McQueen & Andrew Dahlman-Oeth
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
    public float dashModifer;
    public Animator Animat;
    public float plrScale;
    private bool gravityDown = true;
    private Rigidbody2D RB;
    private bool hasAirDash = true;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -8.95f)
        {
            gravityDown = true;
            RB.gravityScale = 1;
        }
        else
        {
            gravityDown = false;
            RB.gravityScale = -1;
        }

        var movement = Input.GetAxis("Horizontal");
        Animat.SetFloat("Speed", Mathf.Abs(movement));
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, transform.position.y));
        Vector2 forward = mouseWorld - transform.position;

        if (forward.x < 0)
        {
            transform.localScale = new Vector3(-plrScale, plrScale, 1);
        }
        else if (forward.x > 0)
        {
            transform.localScale = new Vector3(plrScale, plrScale, 1);
        }

        RB.velocity = new Vector3(movement * MovementSpeed, RB.velocity.y, 0);

        if(Input.GetButtonDown("Jump") && Mathf.Abs(RB.velocity.y) < 0.001f)
        {
            if(gravityDown)
            {
                RB.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
            else
            {
                RB.AddForce(new Vector2(0, -JumpForce), ForceMode2D.Impulse);
            }
            hasAirDash = true;
        }
        if(Input.GetButtonDown("Fire2") && !(Mathf.Abs(RB.velocity.y) < 0.001f))
        {
            if (hasAirDash)
            {
                if (gravityDown)
                {
                    if (movement > 0)
                    {
                        RB.velocity = new Vector2(0, 0);
                        RB.AddForce(new Vector2(MovementSpeed * dashModifer, JumpForce), ForceMode2D.Impulse);
                    }
                    else if (movement < 0)
                    {
                        RB.velocity = new Vector2(0, 0);
                        RB.AddForce(new Vector2(-MovementSpeed * dashModifer, JumpForce), ForceMode2D.Impulse);
                    }
                    else
                    {
                        RB.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                    }
                }
                else
                {
                    if (movement > 0)
                    {
                        RB.velocity = new Vector2(0, 0);
                        RB.AddForce(new Vector2(MovementSpeed * dashModifer, -JumpForce), ForceMode2D.Impulse);
                    }
                    else if (movement < 0)
                    {
                        RB.velocity = new Vector2(0, 0);
                        RB.AddForce(new Vector2(-MovementSpeed * dashModifer, -JumpForce), ForceMode2D.Impulse);
                    }
                    else
                    {
                        RB.AddForce(new Vector2(0, -JumpForce), ForceMode2D.Impulse);
                    }
                }
                hasAirDash = false;
            }
        }
    }


    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GravityLine"))
        {
            if (gravityDown)
            {
                GetComponent<Rigidbody2D>().gravityScale = -1;
                gravityDown = false;
            }
            else
            {
                GetComponent<Rigidbody2D>().gravityScale = 1;
                gravityDown = true;
            }
        }
    }*/
}
