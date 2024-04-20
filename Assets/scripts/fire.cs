using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class fire : MonoBehaviour
{
    //Creation des variables
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private float bulletSpeed = 10f;


    public void FireBullet()
    {
        //Dans la boucle firebullet on va creer un gameobject nommé spawnbullet avec la balle dans la position predifini 
        GameObject spawndBullet= Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);

        //spawnbullet va avoir une vitesse initiale pour aller devant
        spawndBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * bulletSpeed;

        //Detruire la balle apres 6 secondes
        Destroy(spawndBullet, 6f);



    }
}
