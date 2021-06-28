using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Gun[] guns;
    [SerializeField] private Transform firePoint;
    [SerializeField] private int chosenGun;


    public void Shoot(bool AutoFire)
    {
        GameObject bullet = Instantiate(guns[chosenGun].BulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * guns[chosenGun].BulletForce, ForceMode2D.Impulse);
    }

}
