/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Makes it so when an Enemy is hit with a bullet, it is killed
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<ProjectileScript>().ID == 2)
        {
            collision.GetComponent<ProjectileScript>().Hit();
            FindObjectOfType<EndLine>().EnemyKilled();
            Destroy(gameObject);
        }
    }



    
}
