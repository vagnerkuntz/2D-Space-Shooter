using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollision : MonoBehaviour
{
    Fire fireClass = new Fire();
    public GameObject powerUpSound;

    public void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            fireClass.PowerupLaser();
            Instantiate(powerUpSound, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
