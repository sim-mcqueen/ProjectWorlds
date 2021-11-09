/////////////////////////////////////////////////
//// Name: Sim McQueen & Andrew Dahlman-Oeth
//// Date: 11/1/21
//// Proj: ProjectWorlds
//// Desc: Allows the player to shoot projectiles towards the mouse position
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public float projSpeed = 500f;
    public GameObject shootSound;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(shootSound, transform.position, Quaternion.identity);
            Vector3 mouse = Input.mousePosition;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, transform.position.y));
            Vector2 forward = mouseWorld - transform.position;
            GameObject proj = Instantiate(bullet, transform.position, Quaternion.identity);
            Vector3 projTransform = proj.transform.position;
            projTransform.z = 5;
            proj.transform.position = projTransform;
            Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
            ProjectileScript ps = proj.GetComponent<ProjectileScript>();
            ps.ID = 2;
            proj.transform.right = forward;
            rb.AddRelativeForce(proj.transform.right * projSpeed);
        }
    }



}
