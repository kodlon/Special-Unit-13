using UnityEngine;

[CreateAssetMenu(fileName = "Gun",
menuName = "ScriptableObjects/Gun")]
public class GunScriptableObject : ScriptableObject
{
    [SerializeField] private string gunName;
    [TextArea] [SerializeField] private string description;
    [SerializeField] private Sprite playerSprite; //TODO: or maybe gun sprite, be better
    [SerializeField] private Sprite cartridgeFirearms;
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private int amountOfBullet; //how many bullets spawn in one shot
    [SerializeField] private float fireRate; //FIXME: delete timebeforeshoot, and make bool. FireRate before shoot or after
    [SerializeField] private float timeBeforeShoot;
    [Range(1f, 2f)] [SerializeField] private float accuracy = 1f;
    [SerializeField] private bool automatic;

    public Bullet BulletPrefab { get => bulletPrefab; private set => bulletPrefab = value; }
    public int AmountOfBullet { get => amountOfBullet; private set => amountOfBullet = value; }
    public float FireRate { get => fireRate; private set => fireRate = value; }
    public float TimeBeforeShoot { get => timeBeforeShoot; private set => timeBeforeShoot = value; }
    public float Accuracy { get => accuracy; private set => accuracy = value; }
    public bool Automatic { get => automatic; private set => automatic = value; }
}
