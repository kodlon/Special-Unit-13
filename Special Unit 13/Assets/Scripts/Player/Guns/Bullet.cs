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
        Destroy(gameObject, bulletDestroyTime); //Destroys bullet after without collision with walls
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            //Create and destroy effect aftere collision
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, effectDestroyTime);
            
            Destroy(gameObject);
        }
    }
}
