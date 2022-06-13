using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "EnemyLaser") {
            int totalLives = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().lives -= 1;
            if (totalLives > 0 && GameObject.FindGameObjectsWithTag("Player").Length > 0) {
                StartCoroutine(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().Respawn());
            }
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
