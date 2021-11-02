/////////////////////////////////////////////////
//// Name: Andrew Dahlman-Oeth
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Destroys itself after a given amount of time
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public int destroyTime = 10;


    private void Start()
    {
        StartCoroutine(DestroyObject());
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
