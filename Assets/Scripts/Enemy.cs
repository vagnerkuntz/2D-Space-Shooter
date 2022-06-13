using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Laser") {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
