using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject laser;
    public float fireFreq = 1f;
    private float lastShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time > lastShoot + fireFreq)) {
            Shoot();
        }
    }

    void Shoot() {
        lastShoot = Time.time;
        Instantiate(laser, transform.position, transform.rotation);
    }
}
