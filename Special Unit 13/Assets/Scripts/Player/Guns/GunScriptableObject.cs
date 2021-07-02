using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun", 
menuName = "ScriptableObjects/Gun")]
public class GunScriptableObject : ScriptableObject
{
    [SerializeField] private string gunName;
    [TextArea]
    [SerializeField] private string description;
    [SerializeField] private Sprite playerSprite;
    [SerializeField] private Sprite cartridgeFirearms;
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private int amountOfBullet;
    [SerializeField] private float fireRate;
    [SerializeField] private float timeBeforeShoot;
    [Range(1f, 2f)]
    [SerializeField] private float accuracy = 1f;
    [SerializeField] private bool automatic;

    public Bullet BulletPrefab { get => bulletPrefab; private set => bulletPrefab = value; }
    public int AmountOfBullet { get => amountOfBullet; private set => amountOfBullet = value; }
    public float FireRate { get => fireRate; private set => fireRate = value; }
    public float TimeBeforeShoot { get => timeBeforeShoot; private set => timeBeforeShoot = value; }
    public float Accuracy { get => accuracy; private set => accuracy = value; }
    public bool Automatic { get => automatic; private set => automatic = value; }
}
