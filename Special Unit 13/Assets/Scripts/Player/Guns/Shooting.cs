using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GunScriptableObject[] guns;
    [SerializeField] private Transform firePoint;
    [SerializeField] private int chosenGun;
    private bool isShooting;
    Coroutine lastRoutine = null;
    Coroutine endRoutine = null;
    //Test git
    public void Shoot(bool pressed)
    {
        if (pressed && !isShooting)
        {
            lastRoutine = StartCoroutine(ShootCoroutine());
        }
        else if (!pressed)
        {
            StopCoroutine(lastRoutine);
        }

    }

    public IEnumerator ShootCoroutine()
    {
        isShooting = true;
        while (true)
        {
            yield return new WaitForSeconds(guns[chosenGun].TimeBeforeShoot); //FIXME: Gun died when have this var

            for (int i = 0; i < guns[chosenGun].AmountOfBullet; i++)
            {
                GameObject bullet = Instantiate(guns[chosenGun].BulletPrefab.gameObject, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * guns[chosenGun].BulletPrefab.BulletForce, ForceMode2D.Impulse);
            }

            yield return endRoutine = StartCoroutine(EndShoot());


            if (!guns[chosenGun].Automatic)
            {
                break;
            }

        }
    }

    public IEnumerator EndShoot()
    {
        yield return new WaitForSeconds(guns[chosenGun].FireRate);
        isShooting = false;
    }

}
