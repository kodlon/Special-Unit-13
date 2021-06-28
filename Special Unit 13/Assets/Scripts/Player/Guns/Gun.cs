using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Sprite playerSprite;
    [SerializeField] private Sprite hitEffect;
    [SerializeField] private Sprite cartridgeFirearms;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int damage;
    [SerializeField] private int amountOfBullet;
    [SerializeField] private float bulletForce;
    [SerializeField] private float fireRate;

    public float BulletForce { get => bulletForce; set => bulletForce = value; }
    public GameObject BulletPrefab { get => bulletPrefab; set => bulletPrefab = value; }
}
