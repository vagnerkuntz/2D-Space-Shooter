using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float laserSpeed = 2f;

    void Update()
    {
        float movez = laserSpeed * Time.deltaTime;
        transform.Translate(0, 0, movez);
        Vector3 position = transform.position;

        if ((position.z > 4.9) || (position.z < -4.0)) {
            Destroy(gameObject);
        }
    }
}
