using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private int cooldown = 3;
    private Vector2 projVel;
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
        projVel = fireTo.transform.position - transform.position;
        GameObject proj = Instantiate(projectile, transform.position, Quaternion.identity);
        Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
        rb.velocity += projVel;
        yield return new WaitForSeconds(cooldown);
        ShootAt();
    }
}
