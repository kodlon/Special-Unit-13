using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private int damage;
    [SerializeField] private float bulletForce;
    [SerializeField] private float bulletDestroyTime;
    [SerializeField] GameObject hitEffect;
    [SerializeField] private float effectDestroyTime;

    public float BulletForce { get => bulletForce; set => bulletForce = value; }

    private void Start()
    {
        Destroy(gameObject, bulletDestroyTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, effectDestroyTime);
            Destroy(gameObject);
        }
    }
}
