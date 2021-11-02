using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;



    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 mouse = Input.mousePosition;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, transform.position.y));
            Vector2 forward = mouseWorld - transform.position;
            bullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody2D RB = bullet.GetComponent<Rigidbody2D>();
            RB.velocity += forward;
        }
    }



}
