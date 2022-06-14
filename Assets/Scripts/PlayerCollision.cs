using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject explosion;
    public float invinceDelay = 2f;
    private float spawnTime;

    void Awake() {
        spawnTime = Time.time;
    }

    private void OnTriggerEnter(Collider col) {
        if ((col.gameObject.tag == "EnemyLaser") || (col.gameObject.tag == "Enemy") && (Time.time > spawnTime + invinceDelay)) {
            int totalLives = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().lives -= 1;
            if (totalLives > 0) {
                StartCoroutine(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().Respawn());
            }
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
