using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private float bulletSpeed = 10f;


    public void FireBullet()
    {
        GameObject spawndBullet= Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);
        spawndBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * bulletSpeed;
        Destroy(spawndBullet, 6f);



    }
}
