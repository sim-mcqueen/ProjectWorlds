/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: When attached to the player, the player will die when hit with an enemy bullet or a red slime
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            if (collision.GetComponent<ProjectileScript>().ID == 1)
            {
                collision.GetComponent<ProjectileScript>().Hit();
                SceneManager.LoadScene("Main Menu");
            }
        }

        if(collision.CompareTag("RedSlimeEnemy"))
        {
            SceneManager.LoadScene("Main Menu");
        }
        
    }
}
