/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/3/21
//// Proj: ProjectWorlds
//// Desc: Makes it so when an Enemy is hit with a bullet, it is killed
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject deathPS;
    public GameObject deathSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            if (collision.GetComponent<ProjectileScript>().ID == 2)
            {
                collision.GetComponent<ProjectileScript>().Hit();
                FindObjectOfType<EndLine>().EnemyKilled();
                Instantiate(deathPS, transform.position, Quaternion.identity);
                Instantiate(deathSound, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }



    
}
