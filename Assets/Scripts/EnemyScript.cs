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
