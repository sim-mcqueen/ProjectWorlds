using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            if (collision.GetComponent<ProjectileScript>().ID == 1)
            {
                collision.GetComponent<ProjectileScript>().Hit();
                Destroy(gameObject);
            }
        }
        
    }
}
