using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Fire : MonoBehaviour
{

    public GameObject laserEnemy;
    public float fireFreq = 0.5f;
    private float lastShoot;

    void Update()
    {
        if (Time.time > lastShoot + fireFreq) {
            Fire();
        }
    }

    void Fire() {
        lastShoot = Time.time;
        Instantiate(laserEnemy, transform.position, transform.rotation);
    }
}
