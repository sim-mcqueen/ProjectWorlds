using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float projSpeed = 200f;
    private int cooldown = 3;
    private Vector2 projDir;
    [SerializeField]
    private GameObject fireTo;
    [SerializeField]
    private GameObject projectile;

    private void Start()
    {
        StartCoroutine(ShootAt());
    }

    IEnumerator ShootAt()
    {
        yield return new WaitForSeconds(cooldown);
        projDir = fireTo.transform.position - transform.position;
        GameObject proj = Instantiate(projectile, transform.position, Quaternion.identity);
        Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
        proj.transform.right = fireTo.transform.position - transform.position;
        rb.AddRelativeForce(proj.transform.right * projSpeed);
        StartCoroutine(ShootAt());
    }
}