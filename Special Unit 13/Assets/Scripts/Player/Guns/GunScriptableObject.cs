using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun", 
menuName = "ScriptableObjects/Guns", order = 0)]
public class GunScriptableObject : ScriptableObject
{
    [SerializeField] private Sprite playerSprite;
    [SerializeField] private Sprite cartridgeFirearms;
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private int amountOfBullet;
    [SerializeField] private float fireRate;
    [SerializeField] private float timeBeforeShoot;

    public Bullet BulletPrefab { get => bulletPrefab; set => bulletPrefab = value; }
}
