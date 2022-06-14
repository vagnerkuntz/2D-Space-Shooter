using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Fire : MonoBehaviour
{

    public GameObject laserEnemy;
    public float fireFreq = 1f;
    private float lastShoot;

    void Start()
    {
        fireFreq *= Random.Range(0.8, 1.2);
    }

    void FixedUpdate()
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
