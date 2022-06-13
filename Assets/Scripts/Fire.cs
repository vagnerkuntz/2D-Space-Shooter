using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject laser;
    public float fireFreq = 1f;
    private float lastShoot;
    public int laserType = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time > lastShoot + fireFreq)) {
            Shoot();
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot() {
        lastShoot = Time.time;
        if (laserType == 0) {
            Instantiate(laser, transform.position, transform.rotation);
        } else if (laserType == 1) {
            Instantiate(laser, transform.position, Quaternion.Euler(0, -20, 0));
            yield return new WaitForSeconds(0.1f);
            Instantiate(laser, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.1f);
            Instantiate(laser, transform.position, Quaternion.Euler(0, 20, 0));
        }
    }

    public void PowerupLaser() {
        Debug.Log("powerup");
    }
}
