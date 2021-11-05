/////////////////////////////////////////////////
//// Name: Andrew Dahlman-Oeth
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Enemy shoots bullets at player on an interval
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Color projColor;
    public float projSpeed = 200f;
    public int cooldownHigh = 3;
    public int cooldownLow = 1;
    private Vector2 projDir;
    [SerializeField]
    private GameObject fireTo;
    [SerializeField]
    private GameObject projectile;

    private void Start()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            StartCoroutine(ShootAt());
        }
        else
        {
            StartCoroutine(NotOnScreen());
        }
    }

    IEnumerator ShootAt()
    {
        projDir = fireTo.transform.position - transform.position;
        GameObject proj = Instantiate(projectile, transform.position, Quaternion.identity);
        proj.GetComponent<SpriteRenderer>().color = projColor;
        Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
        proj.transform.right = fireTo.transform.position - transform.position;
        rb.AddRelativeForce(proj.transform.right * projSpeed);
        yield return new WaitForSeconds(Random.Range(cooldownLow, cooldownHigh));
        if (GetComponent<Renderer>().isVisible)
        {
            StartCoroutine(ShootAt());
        }
        else
        {
            StartCoroutine(NotOnScreen());
        }
    }

    IEnumerator NotOnScreen()
    {
        yield return new WaitForSeconds(Random.Range(cooldownLow, cooldownHigh));
        if(GetComponent<Renderer>().isVisible)
        {
            StartCoroutine(ShootAt());
        }
        else
        {
            StartCoroutine(NotOnScreen());
        }
    }
}
