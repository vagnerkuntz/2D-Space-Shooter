using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollision : MonoBehaviour
{
    public GameObject powerUpSound;

    public void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            GameObject.Find("Player").GetComponent<Fire>().PowerupLaser();
            Instantiate(powerUpSound, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
