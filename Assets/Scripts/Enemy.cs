using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points = 1;

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Laser") {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().totalEnimies -= 1;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().score += points;

            Drop();

            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    void Drop() {
        if (Random.Range(0, 20) < 15) {
            Instantiate(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().powerUpPrefab, transform.position, transform.rotation);
        }
    }
}
