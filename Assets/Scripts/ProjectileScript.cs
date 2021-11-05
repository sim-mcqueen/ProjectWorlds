/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Gives the bullet an ID, which allows other Scripts to see who shot it
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public int ID = 1;

    public void Hit()
    {
        Destroy(gameObject);
    }
}
