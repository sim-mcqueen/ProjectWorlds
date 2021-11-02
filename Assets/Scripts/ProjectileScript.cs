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
