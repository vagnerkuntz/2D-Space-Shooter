using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
    public Vector2 enemyWiggle;
    public float enemySpeed = 0.8f;

    void Update()
    {
        //transform.position = new Vector3(Mathf.PingPong(Time.time * enemySpeed, enemyWiggle.x), transform.position.y, transform.position.z);
    }
}
